#include <SoftwareSerial.h>

SoftwareSerial RS485Serial(10,11);


void setup()
{
  pinMode(3,OUTPUT);
  digitalWrite(3,LOW);
  RS485Serial.begin(9600);
}
void loop()
int data = analogRead(A0);
{
  digitalWrite(3,HIGH);
  RS485Serial.write(data);
  delay(1000);
}
