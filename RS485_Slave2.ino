#include <SoftwareSerial.h>
SoftwareSerial mySerial(3,2);


void setup() {
  mySerial.begin (9600);
  Serial.begin(9600);
}
 
void loop() {
 int data = analogRead(A0);
mySerial.println(data);
  delay(100);
}
