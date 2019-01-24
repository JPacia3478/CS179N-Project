using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipRoc : MonoBehaviour {

    public Image dagger1;
    public Image dagger2;
    public Image armor1;
    //public Image armor2;
    public Image boots1;
    public int ownDagger1;
    public int ownDagger2;
    public int ownArmor1;
    //public int ownArmor2;
    public int ownBoots1;
    public Image equipweapon1;
    public Button unequip1;
    public Image equipweapon2;
    public Button unequip2;
    public Image equiparmor1;
    public Button unequip3;
    //public Image equiparmor2;
    //public Button unequip4;
    public Image equipboots1;
    public Button unequip5;
    public int weaponNumber;
    public int armorNumber;
    public int bootsNumber;
    public int charNumber;

    void Update()
    {
        ownDagger1 = PlayerPrefs.GetInt("isGrimSold");
        ownDagger2 = PlayerPrefs.GetInt("isKamaiSold");
        ownArmor1 = PlayerPrefs.GetInt("isCloakSold");
        //ownArmor2 = PlayerPrefs.GetInt("isPlateSold");
        ownBoots1 = PlayerPrefs.GetInt("isSandalsSold");
        weaponNumber = PlayerPrefs.GetInt("weaponRoc");
        armorNumber = PlayerPrefs.GetInt("armorRoc");
        bootsNumber = PlayerPrefs.GetInt("bootsRoc");
        PlayerPrefs.SetInt("CharacterNo", 3);
        Update_EquipList();
        Update_Equipped();
    }

    public void Equip_Dagger1()
    {
        if (weaponNumber == 2)
        {
            Unequip2();
            equipweapon1.gameObject.SetActive(true);
            unequip1.gameObject.SetActive(true);
            weaponNumber = 1;
            PlayerPrefs.SetInt("weaponRoc", weaponNumber);
        }
        else
        {
            equipweapon1.gameObject.SetActive(true);
            unequip1.gameObject.SetActive(true);
            weaponNumber = 1;
            PlayerPrefs.SetInt("weaponRoc", weaponNumber);
        }
    }

    public void Unequip1()
    {
        equipweapon1.gameObject.SetActive(false);
        unequip1.gameObject.SetActive(false);
        weaponNumber = 0;
        PlayerPrefs.SetInt("weaponRoc", weaponNumber);
    }

    public void Equip_Dagger2()
    {
        if (weaponNumber == 1)
        {
            Unequip1();
            equipweapon2.gameObject.SetActive(true);
            unequip2.gameObject.SetActive(true);
            weaponNumber = 2;
            PlayerPrefs.SetInt("weaponRoc", weaponNumber);
        }
        else
        {
            equipweapon2.gameObject.SetActive(true);
            unequip2.gameObject.SetActive(true);
            weaponNumber = 2;
            PlayerPrefs.SetInt("weaponRoc", weaponNumber);
        }
    }

    public void Unequip2()
    {
        equipweapon2.gameObject.SetActive(false);
        unequip2.gameObject.SetActive(false);
        weaponNumber = 0;
        PlayerPrefs.SetInt("weaponRoc", weaponNumber);
    }

    public void Equip_Armor1()
    {
        if (armorNumber == 2)
        {
            //Unequip4();
            equiparmor1.gameObject.SetActive(true);
            unequip3.gameObject.SetActive(true);
            armorNumber = 1;
            PlayerPrefs.SetInt("armorRoc", armorNumber);
        }
        else
        {
            equiparmor1.gameObject.SetActive(true);
            unequip3.gameObject.SetActive(true);
            armorNumber = 1;
            PlayerPrefs.SetInt("armorRoc", armorNumber);
        }
    }

    public void Unequip3()
    {
        equiparmor1.gameObject.SetActive(false);
        unequip3.gameObject.SetActive(false);
        armorNumber = 0;
        PlayerPrefs.SetInt("armorRoc", armorNumber);
    }

    /*public void Equip_Armor2()
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
    }*/

    public void Equip_Boots1()
    {
        equipboots1.gameObject.SetActive(true);
        unequip5.gameObject.SetActive(true);
        bootsNumber = 1;
        PlayerPrefs.SetInt("bootsRoc", bootsNumber);
    }

    public void Unequip5()
    {
        equipboots1.gameObject.SetActive(false);
        unequip5.gameObject.SetActive(false);
        bootsNumber = 0;
        PlayerPrefs.SetInt("bootsRoc", bootsNumber);
    }

    public void Update_EquipList()
    {
        if (ownDagger1 == 1)
        {
            dagger1.gameObject.SetActive(true);
        }
        else
        {
            dagger1.gameObject.SetActive(false);
        }
        if (ownDagger2 == 1)
        {
            dagger2.gameObject.SetActive(true);
        }
        else
        {
            dagger2.gameObject.SetActive(false);
        }
        if (ownArmor1 == 1)
        {
            armor1.gameObject.SetActive(true);
        }
        else
        {
            armor1.gameObject.SetActive(false);
        }
        /*if (ownArmor2 == 1)
        {
            armor2.gameObject.SetActive(true);
        }
        else
        {
            armor2.gameObject.SetActive(false);
        }*/
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
        if (weaponNumber == 1)
        {
            Equip_Dagger1();
        }
        else if (weaponNumber == 2)
        {
            Equip_Dagger2();
        }
        if (armorNumber == 1)
        {
            Equip_Armor1();
        }
        /*else if (armorNumber == 2)
        {
            Equip_Armor2();
        }*/
        if (bootsNumber == 1)
        {
            Equip_Boots1();
        }
    }
}
