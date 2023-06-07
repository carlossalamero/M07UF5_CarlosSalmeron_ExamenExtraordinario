using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManagerArm : MonoBehaviour
{
    public static InventoryManagerArm instance;

    public ScriptableArmature[] armatures;
    public Text[] armaturesNames;
    public Image[] armaturesSprites;
    public Text[] armaturesPrices;

    void Awake()
    {
        instance  = this;
    }

    public void AddArmature(ScriptableArmature armature)
    {
        for (int j = 0; j < armatures.Length; j++)
        {
            if(armatures[j] == null )
            {
                armatures[j] = armature;
                armaturesNames[j].text = armature.armatureName;
                armaturesSprites[j].sprite = armature.armatureSprite;
                armaturesPrices[j].text = armature.armaturePrice;

                return;
            }
        }
    }
}
