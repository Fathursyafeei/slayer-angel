using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManaBar : MonoBehaviour {
    [SerializeField] private Slider slider;
    [SerializeField] private Gradient gradient;
    [SerializeField] private Image fill;

    public void SetMaxMana(float mana) {
        slider.maxValue = mana;
        slider.value = mana;
        fill.color = gradient.Evaluate(1f);
    }

    // function setting slider
    public void SetMana(float mana) {
        slider.value = mana;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
