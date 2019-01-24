using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipXylia : MonoBehaviour {

    public Image sword1;
    public Image sword2;
    public Image armor1;
    public Image armor2;
    public Image boots1;
    public int ownSword1;
    public int ownSword2;
    public int ownArmor1;
    public int ownArmor2;
    public int ownBoots1;
    public Image equipweapon1;
    public Button unequip1;
    public Image equipweapon2;
    public Button unequip2;
    public Image equiparmor1;
    public Button unequip3;
    public Image equiparmor2;
    public Button unequip4;
    public Image equipboots1;
    public Button unequip5;
    public int weaponNumber;
    public int armorNumber;
    public int bootsNumber;
    public int charNumber;

    void Update()
    {
        ownSword1 = PlayerPrefs.GetInt("isMystSold");
        ownSword2 = PlayerPrefs.GetInt("isTyrfSold");
        ownArmor1 = PlayerPrefs.GetInt("isCuirassSold");
        ownArmor2 = PlayerPrefs.GetInt("isPlateSold");
        ownBoots1 = PlayerPrefs.GetInt("isGreavesSold");
        weaponNumber = PlayerPrefs.GetInt("weaponXylia");
        armorNumber = PlayerPrefs.GetInt("armorXylia");
        bootsNumber = PlayerPrefs.GetInt("bootsXylia");
        PlayerPrefs.SetInt("CharacterNo", 1);
        Update_EquipList();
        Update_Equipped();
    }

    public void Equip_Sword1()
    {
        if(weaponNumber == 2)
        {
            Unequip2();
            equipweapon1.gameObject.SetActive(true);
            unequip1.gameObject.SetActive(true);
            weaponNumber = 1;
            PlayerPrefs.SetInt("weaponXylia", weaponNumber);
        }
        else
        {
            equipweapon1.gameObject.SetActive(true);
            unequip1.gameObject.SetActive(true);
            weaponNumber = 1;
            PlayerPrefs.SetInt("weaponXylia", weaponNumber);
        }
    }

    public void Unequip1()
    {
        equipweapon1.gameObject.SetActive(false);
        unequip1.gameObject.SetActive(false);
        weaponNumber = 0;
        PlayerPrefs.SetInt("weaponXylia", weaponNumber);
    }

    public void Equip_Sword2()
    {
        if (weaponNumber == 1)
        {
            Unequip1();
            equipweapon2.gameObject.SetActive(true);
            unequip2.gameObject.SetActive(true);
            weaponNumber = 2;
            PlayerPrefs.SetInt("weaponXylia", weaponNumber);
        }
        else
        {
            equipweapon2.gameObject.SetActive(true);
            unequip2.gameObject.SetActive(true);
            weaponNumber = 2;
            PlayerPrefs.SetInt("weaponXylia", weaponNumber);
        }
    }

    public void Unequip2()
    {
        equipweapon2.gameObject.SetActive(false);
        unequip2.gameObject.SetActive(false);
        weaponNumber = 0;
        PlayerPrefs.SetInt("weaponXylia", weaponNumber);
    }

    public void Equip_Armor1()
    {
        if(armorNumber == 2)
        {
            Unequip4();
            equiparmor1.gameObject.SetActive(true);
            unequip3.gameObject.SetActive(true);
            armorNumber = 1;
            PlayerPrefs.SetInt("armorXylia", armorNumber);
        }
        else
        {
            equiparmor1.gameObject.SetActive(true);
            unequip3.gameObject.SetActive(true);
            armorNumber = 1;
            PlayerPrefs.SetInt("armorXylia", armorNumber);
        }
    }

    public void Unequip3()
    {
        equiparmor1.gameObject.SetActive(false);
        unequip3.gameObject.SetActive(false);
        armorNumber = 0;
        PlayerPrefs.SetInt("armorXylia", armorNumber);
    }

    public void Equip_Armor2()
    {
        if (armorNumber == 2)
        {
            Unequip3();
            equiparmor2.gameObject.SetActive(true);
            unequip4.gameObject.SetActive(true);
            armorNumber = 2;
            PlayerPrefs.SetInt("armorXylia", armorNumber);
        }
        else
        {
            equiparmor2.gameObject.SetActive(true);
            unequip4.gameObject.SetActive(true);
            armorNumber = 2;
            PlayerPrefs.SetInt("armorXylia", armorNumber);
        }
    }

    public void Unequip4()
    {
        equiparmor2.gameObject.SetActive(false);
        unequip4.gameObject.SetActive(false);
        armorNumber = 0;
        PlayerPrefs.SetInt("armorXylia", armorNumber);
    }

    public void Equip_Boots1()
    {
        equipboots1.gameObject.SetActive(true);
        unequip5.gameObject.SetActive(true);
        bootsNumber = 1;
        PlayerPrefs.SetInt("bootsXylia", bootsNumber);
    }

    public void Unequip5()
    {
        equipboots1.gameObject.SetActive(false);
        unequip5.gameObject.SetActive(false);
        bootsNumber = 0;
        PlayerPrefs.SetInt("bootsXylia", bootsNumber);
    }

    public void Update_EquipList()
    {
        if(ownSword1 == 1)
        {
            sword1.gameObject.SetActive(true);
        }
        else
        {
            sword1.gameObject.SetActive(false);
        }
        if (ownSword2 == 1)
        {
            sword2.gameObject.SetActive(true);
        }
        else
        {
            sword2.gameObject.SetActive(false);
        }
        if (ownArmor1 == 1)
        {
            armor1.gameObject.SetActive(true);
        }
        else
        {
            armor1.gameObject.SetActive(false);
        }
        if (ownArmor2 == 1)
        {
            armor2.gameObject.SetActive(true);
        }
        else
        {
            armor2.gameObject.SetActive(false);
        }
        if (ownBoots1 == 1)
        {
            boots1.gameObject.SetActive(true);
        }
        else
        {
            boots1.gameObject.SetActive(false);
        }
    }

    public void Update_Equipped()
    {
        if(weaponNumber == 1)
        {
            Equip_Sword1();
        }
        else if(weaponNumber == 2)
        {
            Equip_Sword2();
        }
        if (armorNumber == 1)
        {
            Equip_Armor1();
        }
        else if (armorNumber == 2)
        {
            Equip_Armor2();
        }
        if(bootsNumber == 1)
        {
            Equip_Boots1();
        }
    }
}
