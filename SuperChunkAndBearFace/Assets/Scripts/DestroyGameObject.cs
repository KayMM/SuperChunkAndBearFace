using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DestroyGameObject : MonoBehaviour
{
    public Slider slider;
    public TMP_Text itemsLeft;
    public float health;
    public int itemsRemaining;
    void Update() {
        slider.value = health;
        health = health - .05f;

    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bone")
        {
            Destroy(collision.gameObject);
            health = health + 20f;
        }

        if (collision.gameObject.tag == "Hedgehog")
        {
            Destroy(collision.gameObject);
            itemsRemaining = itemsRemaining - 1;
            itemsLeft.text = itemsRemaining.ToString();
        }
    }
}
