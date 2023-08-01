char estadoSerial = '0';

//Configurando portas do led
const int LED = 12;
const int LED2 = 13;

void setup() {
  //Ativando monitor serial
  Serial.begin(9600);
  //Configurando LEDs
  pinMode(LED, OUTPUT);
  digitalWrite(LED, LOW);
  digitalWrite(LED2, LOW);
}
void loop(){

  //Retorna o número de bytes (caracteres) disponíveis para leitura da porta serial. 
  if (Serial.available() > 0) { 
     estadoSerial = Serial.read();
  }

  //Se a serial receber o valor 1
  if (estadoSerial == '1'){ 
    //ligar led
     digitalWrite(LED, HIGH);
  }

  //Se a serial receber o valor 0
  if (estadoSerial == '0'){ 
    //desligar led
     digitalWrite(LED, LOW);
  }

  //Se a serial receber o valor b
  if (estadoSerial == 'b'){ 
    //ligar segundo led
     digitalWrite(LED2, HIGH);
  }

  //Se a serial receber o valor a
  if (estadoSerial == 'a'){ 
    //desligar segundo led
     digitalWrite(LED2, LOW);
  }
  //fim
}