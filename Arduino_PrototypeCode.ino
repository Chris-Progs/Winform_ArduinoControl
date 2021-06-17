// Use library matching DHT sensor
#include "DHT.h"

// DHT sensor frunction
int DHT11Pin = 4;
DHT dht(DHT11Pin, DHT11);
float humidity = 0;
float celsius = 0;

// Rotation sensor function
int rotationPin = A0;
int data = 0;
int RGBRedPin = 9;
int RGBGreenPin = 10;
int RGBBluePin = 11;

// Buzzer function
int buzzerPin = 5;
int maxTemp = 40;
int waitTime = 500;

// Red LED button function
int redLed = 12;
bool redLedOnStatus = false;

// Outside temp function
const int sensorLM35 = A2;
float tempc;
float vout;

// Light sensor function
int light_pin = A1;
int light_data = 0;
int blueLed = 13;

// Setup serial port with baud rate, inputs plus outputs and start the DHT sensor.
void setup() {
  Serial.begin(9600);
  pinMode(blueLed, OUTPUT);
  pinMode(sensorLM35, INPUT);
  pinMode(redLed, OUTPUT);
  pinMode(RGBRedPin, OUTPUT);
  pinMode(RGBGreenPin, OUTPUT);
  pinMode(RGBBluePin, OUTPUT);
  pinMode(light_data, INPUT);
  pinMode(buzzerPin, OUTPUT);
  dht.begin();
}

void loop() {
  delay(1000);
  // Method for reading outside temp and converting to celsius first then inside humidity and temp as celsius.
  // Display data through serial port
  vout = analogRead(sensorLM35);
  vout = (vout * 500) / 1023;
  tempc = vout;
  humidity = dht.readHumidity();
  celsius = dht.readTemperature();
  Serial.print(tempc);
  Serial.print(",");
  Serial.print(humidity);
  Serial.print(",");
  Serial.println(celsius);
  // Method for turning red LED light on and off with button click within GUI and passing max temp value to combo box.
  int val = Serial.parseInt();
  switch (val) {
    case 0:
      break;
    case 100:
      digitalWrite(redLed, HIGH);
      break;
    case 101:
      digitalWrite(redLed, LOW);
      break;
    default:
      maxTemp = val;
      break;
  }
  // Method for sounding buzzer pin when DHT celsius read is over the max set of 40 or user's choice from combo box within GUI.
  if (celsius > maxTemp) {
    tone(buzzerPin, 1000, 50);
    delay(waitTime);
    tone(buzzerPin, 3000, 100);
  }
  // Method for light sensor to turn on blue LED light when room is considered dark enough, otherwise leave blue LED off.
  light_data = analogRead(light_pin);
  if (light_data < 480)
  {
    digitalWrite(blueLed, HIGH);
    delay(10000);
  } else {
    digitalWrite(blueLed, LOW);
  }
  // Method for displaying RGB LED light colour based on user input with rotation pin, options are red, green and blue.
  // To simplify data divide value by 300 and use swtich case of 1, 2 and 3.
  data = analogRead(rotationPin);
  data = data / 300;
  switch (data) {
    case 1: {
        digitalWrite(RGBRedPin, HIGH);
        digitalWrite(RGBBluePin, LOW);
        digitalWrite(RGBGreenPin, LOW);
        break;
      }
    case 2: {
        digitalWrite(RGBRedPin, LOW);
        digitalWrite(RGBBluePin, LOW);
        digitalWrite(RGBGreenPin, HIGH);
        break;
      }
    case 3: {
        digitalWrite(RGBRedPin, LOW);
        digitalWrite(RGBBluePin, HIGH);
        digitalWrite(RGBGreenPin, LOW);
        break;
      }
  }
}
