using UnityEngine;


public class DamageMec : MonoBehaviour

{
    void Start()
    {
        int basicDamage = Random.Range(10, 100);
        float damage = MakeDamage(basicDamage, 2.1f);
        Debug.Log($"Player make damage = {damage}");
        int basicExperience = Random.Range(5, 10);
        Debug.Log($"Player get experience = {GetExperience(basicExperience, 2)}");
        Debug.Log($"Player get lvl up = {GetLevelUp()}");
    }


    void Update()
    {
        int basicDamage = Random.Range(10, 100);
        float damage = MakeDamage(basicDamage, 2.1f);
        Debug.Log($"Player make damage = {damage}");
    }

    public bool GetLevelUp()
    {
        return true;
    }

    public float GetExperience(float damage, int param)
    {
        return damage * param;
    }

    public float MakeDamage(int baseDamage, float multiplier)
    {
        return baseDamage * multiplier;
    }

}
