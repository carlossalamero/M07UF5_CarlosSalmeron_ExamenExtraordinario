using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItem : MonoBehaviour
{
    public ScriptableWeapon weapon;
    public ScriptableArmature armature;

    SpriteRenderer sRenderer;
    SpriteRenderer aRenderer;

    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();

        sRenderer.sprite = weapon.weaponSprite;
        aRenderer.sprite = armature.armatureSprite;
    }
}
