#define DIR1 8
#define DIR2 9
#define PWM_INPUT 3

#define REFRESH 700

int i;

void setup() {
  pinMode(DIR1, OUTPUT);
  pinMode(DIR2, OUTPUT);
  pinMode(PWM_INPUT, OUTPUT);

  digitalWrite(DIR1, LOW);
  digitalWrite(DIR2, HIGH);

  Serial.begin(9600);
}

void loop() {

  analogWrite(PWM_INPUT, 200);
  delay(2000);

//  for(i = 0; i < 128; i+=4) {
//    Serial.println(i);
//    analogWrite(PWM_INPUT, i);
//    delay(300);
//  }
//
//  for(i = 128; i < 180; i+=10) {
//    Serial.println(i);
//    analogWrite(PWM_INPUT, i);
//    delay(500);
//  }
//
//  for(int i = 180; i < 210; i+=4) {
//    Serial.println(i);
//    analogWrite(PWM_INPUT, i);
//    delay(300);
//  }
  

  
  
}

//rise, hold at max for 2 seconds, then fall
//for(int i = 0; i < 255; i+=2) {
//    analogWrite(PWM_INPUT, i);
//    delay(30);
//  }
//
//  analogWrite(PWM_INPUT, 255);
//  delay(2000);
//
//  for(int i = 255; i > 0; i-=2) {
//    analogWrite(PWM_INPUT, i);
//    delay(30);
//  }
//  
//  delay(1000);

//bad guy on beat?
//  analogWrite(PWM_INPUT, 255);
//  delay(222);
//  analogWrite(PWM_INPUT, 0);
//  delay(222);

//on, then off
//analogWrite(PWM_INPUT, 255);
  //delay(1000);
  //analogWrite(PWM_INPUT, 0);
  //delay(1000);
