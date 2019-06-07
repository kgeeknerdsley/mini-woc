#include <SD.h>
#include <SPI.h>

#define DIR1 8
#define DIR2 9
#define PWM_INPUT 3

File showData;

int cmdTime;
int power;
int color;

char showName[] = "testshow.dat";

void setup() {

  pinMode(DIR1, OUTPUT);
  pinMode(DIR2, OUTPUT);
  pinMode(PWM_INPUT, OUTPUT);

  digitalWrite(DIR1, LOW); //hook to GND
  digitalWrite(DIR2, HIGH); //hook to 5V
  
  Serial.begin(9600);
  //delay(20);
  //Serial.setTimeout(50); //maybe not necessary

  pinMode(SS, OUTPUT);
  //pinMode(10, OUTPUT);

  if(!SD.begin(10)) {
    Serial.println("SD card did not initialize. Reboot please");
    while(1);
  }

  if(SD.exists(showName)) {
    Serial.println("Show located. Beginning");

    showData = SD.open(showName, FILE_READ);
  } else {
    Serial.println("Show not found. Check SD card");
    while(1);
  }

}

void loop() {

  if(!showData.available()) {
    Serial.println("Show complete");
    while(1);
  } else {
    cmdTime = showData.parseInt();
    power = showData.parseInt();
    color = showData.parseInt();

    playFountain(cmdTime, power);

  }
}

void playFountain(int duration, int pwmVal) {
  Serial.print("Playing fountain at ");
  Serial.print(pwmVal);
  Serial.print(" for ");
  Serial.print(duration);
  Serial.println(" ms");
  
  analogWrite(PWM_INPUT, pwmVal);
  delay(duration);
}

