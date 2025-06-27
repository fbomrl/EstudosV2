

public class Animon {

        //explicação sobre variáveis
    int speed;
    string name = "Metanik";
    bool isDead = true; 
    float health;

    //referenciar a outra classe:

    AnimonWeapon weapon;


    //Array
    int [] intArray = new int[] {1,2,3,4,5,6,7,8,9,10};
    //List
    List<int> intList = new List<int>() {1,2,3,4,5,6,7,8,9,10};



    //funções e métodos.
    void Movement()
    {
        //estrutturas de repetição
        foreach (int intNumbers in intList)
        {
            
        }

        for (int i = 0; i < intArray.Length; i++)
        {
           int currentNumber =  intArray[i];
        }
        //Quando é passado um List no for, tem que usar Count e não Length.
         for (int i = 0; i < intList.Count; i++)
        {
        int currentNumber = intList[i];
        }
        

        //adicionando a lista + 3,
        intList.Add(3);
        //para remover é só utilizar a situação abaixo
        intList.Remove(1);


        //Condicionais:
        if (speed > 0 && health > 0) 
        {
            
        }
        else
        {

        }
    }

    void Attack()
    {
        weapon.Shoot();
        weapon.damage = 30;   
        weapon.fireRate = 0.4f;
 }

    void Dead()
    {
        if(health <= 0) 
        {

        }
    }
}

//Explicação sobre classes distintas.

public class AnimonWeapon
{

    //Quando não é declarado o estado das variaveis e métodos, automaticamente o compilador entende ele como privado.
    public float damage;
    public float fireRate;

    public void Shoot()
    {

    }
}