#include <SoftwareSerial.h>
SoftwareSerial RS485Serial(10,11); 
int data;

void setup()
{
  Serial.begin(9600);
  Serial.println("Komunikasi RS485 : ");
  pinMode(3,OUTPUT);
  digitalWrite(3,LOW);
  RS485Serial.begin(9600);
}
void loop()
{
  if (RS485Serial.available())
  {
    data = RS485Serial.read();
    Serial.println();
  }
}

