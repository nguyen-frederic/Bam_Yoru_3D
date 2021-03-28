using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Objets à spawn")]
    [SerializeField] private GameObject[] mob;
    [Space]
    [SerializeField] private float rechargeMax;
    private float recharge;

    private void FixedUpdate()
    {
        if (recharge > 0)
        {
            recharge -= Time.fixedDeltaTime;
        }
        else
        {
            float rand_temps = Random.Range(0.8f, 1.2f);
            recharge = rechargeMax * rand_temps;
            int rand = Random.Range(0, mob.Length);
            Instantiate(mob[rand], transform.position, Quaternion.identity);
        }
    }
}
