using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesManager : MonoBehaviour
{
    public int health;
    public int attack;
    public float critDamage = 1.5f;
    public float critChance = 0.5f;

    public void TakeDamage(int amount)
    {
        health -= amount;
        DamagePopUpGenerator.current.CreatePopUp(transform.position,amount.ToString());

    }
    public void DealDamage(GameObject target)
    {
        var atm = target.GetComponent<AttributesManager>();
        if (atm != null)
        {
        float totalDamage = attack;
            if(Random.Range(0f, 1f) < critDamage)
            {
                totalDamage *= critDamage;
            }
            atm.TakeDamage((int)totalDamage);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
