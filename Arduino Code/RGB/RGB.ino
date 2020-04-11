int R;
int G;
int B;
String hex;
#define Rpin 11
#define Gpin 10
#define Bpin 9



void setup() {

	Serial.begin(9600);//initalize serial coms 
	pinMode(Rpin, OUTPUT);
	pinMode(Gpin, OUTPUT);
	pinMode(Bpin, OUTPUT);//set pins as outputs 

}

void loop() {
	if (Serial.available()) {
		// wait a bit for the entire message to arrive
		delay(100);
		while (Serial.available() > 0) {
			hex = Serial.readString();

			long number = (long)strtol(&hex[0], NULL, 16);
			R = number >> 16;
			G = number >> 8 & 0xFF;
			B = number & 0xFF; //rgb value seperation 

			analogWrite(Rpin, R);
			analogWrite(Gpin, G);
			analogWrite(Bpin, B);//write values to the pwm registers of arduino 
		}
	}
}
