using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Slider healthSlider;
    public float maxHealth;

    private void Start()
    {
        healthSlider.value = maxHealth;
    }

    private void OnCollisionStay(Collision collision)
    {
        healthSlider.value -= 10;
        Debug.Log(collision.relativeVelocity);
    }
}
