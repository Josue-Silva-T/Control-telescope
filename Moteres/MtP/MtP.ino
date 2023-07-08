
// DEFINICION DE PINES DE SALIDA PARA EL CONTROLADOR DE MOTOR A PASOS
#define IN1  8
#define IN2  9
#define IN3  10
#define IN4  11

void setup()
{
  //DECLARANDO LAS SALIDAS DEL MOTOR A PASOS
  //ENFOCADOR
  pinMode(IN1, OUTPUT);
  pinMode(IN2, OUTPUT);
  pinMode(IN3, OUTPUT);
  pinMode(IN4, OUTPUT);
  
  //DECLARANDO LAS SALIDAS DEL MOTOR AC
  //ROTADOR HORIZONTAL
  pinMode(1, OUTPUT);
  pinMode(2, OUTPUT);
  
  Serial.begin(9600);
}

void loop()
{ 
  //OBTENER LOS DATOS CON SERIAL.READ PARA SU OBTENCION DESDE LESHA CONTROL
    if(Serial.available()>0){
      int a = Serial.parseFloat();
      Serial.println(a);
        //CUANDO B SEA 51 EL MOTOR AC GIRARA EN SENTIDO ANTI-HORARIO
    if(a == 3){
    digitalWrite(1, LOW);
    delay(5000);
    digitalWrite(1, HIGH);
    }
    
    //CUANDO B SEA 52 EL MOTOR AC GIRARA EN SENTIDO HORARIO
    if(a == 4){
    digitalWrite(2, LOW);
    delay(5000);
    digitalWrite(2, HIGH);
    }
      

      if(a == 2){
        for(int i = 0; i < 15; i++){
    digitalWrite(IN1, LOW);                 // sentido anti-horario
    digitalWrite(IN2, LOW);
    digitalWrite(IN3, LOW);
    digitalWrite(IN4, HIGH);
    delay(5);
    digitalWrite(IN1, LOW);
    digitalWrite(IN2, LOW);
    digitalWrite(IN3, HIGH);
    digitalWrite(IN4, LOW);
    delay(5);
    digitalWrite(IN1, LOW);
    digitalWrite(IN2, HIGH);
    digitalWrite(IN3, LOW);
    digitalWrite(IN4, LOW);
    delay(5);
    digitalWrite(IN1, HIGH);
    digitalWrite(IN2, LOW);
    digitalWrite(IN3, LOW);
    digitalWrite(IN4, LOW);
    delay(5);
      }
      //APAGAR
      digitalWrite(IN1, LOW);
      digitalWrite(IN2, LOW);
      digitalWrite(IN3, LOW);
      digitalWrite(IN4, LOW);
      delay(5);
      }
            if(a == 1){
              for(int i = 0; i < 15; i++){
    digitalWrite(IN1, HIGH);                 // sentido agujas del reloj
    digitalWrite(IN2, LOW);
    digitalWrite(IN3, LOW);
    digitalWrite(IN4, LOW);
    delay(5);
    digitalWrite(IN1, LOW);
    digitalWrite(IN2, HIGH);
    digitalWrite(IN3, LOW);
    digitalWrite(IN4, LOW);
    delay(5);
    digitalWrite(IN1, LOW);
    digitalWrite(IN2, LOW);
    digitalWrite(IN3, HIGH);
    digitalWrite(IN4, LOW);
    delay(5);
    digitalWrite(IN1, LOW);
    digitalWrite(IN2, LOW);
    digitalWrite(IN3, LOW);
    digitalWrite(IN4, HIGH);
    delay(5); 
              }
    //APAGADO
      digitalWrite(IN1, LOW);
      digitalWrite(IN2, LOW);
      digitalWrite(IN3, LOW);
      digitalWrite(IN4, LOW);
      delay(5);
      }
      
      
    }
}
