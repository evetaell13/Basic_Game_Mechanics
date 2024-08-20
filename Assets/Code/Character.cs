using UnityEngine;

public class Character : MonoBehaviour
{

    public int Hp;
    public bool IsDeath = false;


    void Start()
    {
        Hp = 100;
    }

    void Update()
    {
        if (Hp <= 0) 
        {
            Hp = 0;
            IsDeath = true;
        }
    }
}
