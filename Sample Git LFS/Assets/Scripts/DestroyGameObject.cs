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
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bone")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Hedgehog")
        {
            Destroy(collision.gameObject);
            itemsRemaining = itemsRemaining - 1;
            itemsLeft.text = itemsRemaining.ToString();
        }
    }
}
