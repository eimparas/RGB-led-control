int r;
int g;
int b;
String Hex;
#define RpIN 11
#define GpIN 10
#define BpIN 9



void setup() {

	Serial.begin(9600);//initalize serial coms 
	pinMode(RpIN, OUTPUT);
	pinMode(GpIN, OUTPUT);
	pinMode(BpIN, OUTPUT);//set pins as outputs 

}

void loop() {
	if (Serial.available()) {
		// wait a bit for the entire message to arrive
		delay(100);
		while (Serial.available() > 0) {
			Hex = Serial.readString();

			long number = (long)strtol(&Hex[0], NULL, 16);
			r = number >> 16;
			g = number >> 8 & 0xFF;
			b = number & 0xFF; //rgb value seperation 

			analogWrite(RpIN, map(r, 0, 255, 255, 0));
			analogWrite(GpIN, map(g, 0, 255, 255, 0));//values need reversing due to the opto-isoolator
			analogWrite(BpIN, map(b, 0, 255, 255, 0));//write values to the pwm registers of arduino 
		}
	}
}
