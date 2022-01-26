namespace Metaverso
{
    public class Sistema
    {
        public string Saludo(string nombre) => $"Saludos {nombre}!";
        public string metaverso(int[] numeros){
           string resultado="";
           foreach(int numero in numeros){
               resultado+=metaverso(numero);
           } 
           return resultado;
        }
    
        public string metaverso(int numero){
            if (numero%5==0 ){
                if (numero % 3==0){
                    return "Metaverso";
                }
                return "Verso";
            } else if (numero%3==0){
                return "Meta";
            } 
            return numero.ToString();
        }

        
    }
}