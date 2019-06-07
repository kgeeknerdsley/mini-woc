#include <SD.h>
#include <SPI.h>

File showData;

int timeOn;
int power;
int color;
bool arc;
int time1;
int time2;

void setup() {
  Serial.begin(9600);
  Serial.setTimeout(50);

  while(!Serial) {
  }

  Serial.println("Attempting to initialize sd card");
  Serial.println("");

  pinMode(SS, OUTPUT);

  if(!SD.begin(10)) {
    Serial.println("SD card failed to start up");
    while(1);
  }

  Serial.println("SD card initialized");


  if(SD.exists("inttest.dat")) {
    Serial.println("Show data located for test performance");

    showData = SD.open("inttest.dat", FILE_READ);
  } else {
    Serial.println("Show data could not be found");
  }

}

void loop() {
  if(!showData.available()) {
    Serial.println("Out of data to read");
    while(1);
  } else {

    time1 = millis();
    timeOn = showData.parseInt(); //reads one byte at a time
    power = showData.parseInt();
    color = showData.parseInt();
    time2 = millis();

    Serial.print("Time fountain is active (ms): ");
    Serial.println(timeOn);
    Serial.print("PWM value for fountain: ");
    Serial.println(power);
    Serial.print("Color value: ");
    Serial.println(color);
    Serial.print("Elapsed time of file read (ms): ");
    Serial.println(time2-time1);
    Serial.println();
  }
}

void playFountain(int timeActive, int pwmVal){
  Serial.print("Playing fountain for time");
  Serial.println(timeActive);
  
}

