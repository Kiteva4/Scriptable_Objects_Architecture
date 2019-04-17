using UnityEngine;
using UnityEngine.Events;

public class UnitHealth : MonoBehaviour
{
    [SerializeField] private FloatVariable HP;
    [SerializeField] private FloatReference StartingHP;

    [SerializeField] private UnityEvent DamageEvent;
    [SerializeField] private UnityEvent DeathEvent;

}
