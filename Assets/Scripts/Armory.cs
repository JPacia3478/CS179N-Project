using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Armory : MonoBehaviour {

    public Text gold;
    public Text hp_pot;
    public Text sp_pot;
    public Text atk_pot;
    public Text def_pot;
    public Text burn_pot;
    public Text immobile_pot;
    public GameObject hub_menu;
    public GameObject armory_menu;
    public int Gold;
    public int hp_potion_cnt;
    public int sp_potion_cnt;
    public int atk_buff_cnt;
    public int def_buff_cnt;
    public int enchantB_cnt;
    public int enchantI_cnt;
    public GameObject mystel;
    public GameObject tyrf;
    public GameObject grim;
    public GameObject kamai;
    public GameObject gun1;
    public GameObject gun2;
    public GameObject shirt;
    public GameObject cloak;
    public GameObject cuirass;
    public GameObject plate_armor;
    public GameObject sandals;
    public GameObject boots;
    public GameObject greaves;
    public int isItem1Sold;
    public int isItem2Sold;
    public int isItem3Sold;
    public int isItem4Sold;
    public int isItem5Sold;
    public int isItem6Sold;
    public int isItem7Sold;
    public int isItem8Sold;
    public int isItem9Sold;
    public int isItem10Sold;
    public int isItem11Sold;
    public int isItem12Sold;
    public int isItem13Sold;

    void Start()
    {
        Gold = PlayerPrefs.GetInt("CurrentGold");
        hp_potion_cnt = PlayerPrefs.GetInt("CurrentHPPotion");
        sp_potion_cnt = PlayerPrefs.GetInt("CurrentSPPotion");
        atk_buff_cnt = PlayerPrefs.GetInt("CurrentAtkBuff");
        def_buff_cnt = PlayerPrefs.GetInt("CurrentDefBuff");
        enchantB_cnt = PlayerPrefs.GetInt("CurrentEnchantB");
        enchantI_cnt = PlayerPrefs.GetInt("CurrentEnchantI");
        InitializeShop();
    }

    void Update()
    {
        gold.text = Gold+"   Gold";
        PlayerPrefs.SetInt("CurrentGold", Gold);
        hp_pot.text = "Healing Potion " + hp_potion_cnt + "x";
        sp_pot.text = "SP Potion " + sp_potion_cnt + "x";
        atk_pot.text = "Atk Buff " + atk_buff_cnt + "x";
        def_pot.text = "Def Buff " + def_buff_cnt + "x";
        burn_pot.text = "Burn Potion " + enchantB_cnt + "x";
        immobile_pot.text = "Immobile Potion " + enchantI_cnt + "x";
    }

    public void Armory_Back()
    {
        armory_menu.SetActive(false);
        hub_menu.SetActive(true);
    }

    public void Buy_Heal()
    {
        if(Gold >= 100)
        {
            hp_potion_cnt++;
            Gold -= 100;
            Debug.Log("Bought 1 HP Potion");
            PlayerPrefs.SetInt("CurrentHPPotion", hp_potion_cnt);
        }
        else
        {
            Debug.Log("Not enough Gold");
        }
    }

    public void Buy_SP()
    {
        if (Gold >= 100)
        {
            sp_potion_cnt++;
            Gold -= 100;
            Debug.Log("Bought 1 SP Potion");
            PlayerPrefs.SetInt("CurrentSPPotion", sp_potion_cnt);
        }
        else
        {
            Debug.Log("Not enough Gold");
        }
    }

    public void Buy_AtkBuff()
    {
        if (Gold >= 250)
        {
            atk_buff_cnt++;
            Gold -= 250;
            Debug.Log("Bought 1 Atk Buff");
            PlayerPrefs.SetInt("CurrentAtkBuff", atk_buff_cnt);
        }
        else
        {
            Debug.Log("Not enough Gold");
        }
    }

    public void Buy_DefBuff()
    {
        if (Gold >= 250)
        {
            def_buff_cnt++;
            Gold -= 250;
            Debug.Log("Bought 1 Def Buff");
            PlayerPrefs.SetInt("CurrentDefBuff", def_buff_cnt);
        }
        else
        {
            Debug.Log("Not enough Gold");
        }
    }

    public void Buy_EnchantB()
    {
        if (Gold >= 400)
        {
            enchantB_cnt++;
            Gold -= 400;
            Debug.Log("Bought 1 Burn Potion");
            PlayerPrefs.SetInt("CurrentEnchantB", enchantB_cnt);
        }
        else
        {
            Debug.Log("Not enough Gold");
        }
    }

    public void Buy_EnchantI()
    {
        if (Gold >= 300)
        {
            enchantI_cnt++;
            Gold -= 300;
            Debug.Log("Bought 1 Immobile Potion");
            PlayerPrefs.SetInt("CurrentEnchantI", enchantI_cnt);
        }
        else
        {
            Debug.Log("Not enough Gold");
        }
    }

    public void Buy_Mysteltainn()
    {
        if (Gold >= 5000)
        {
            Gold -= 5000;
            mystel.SetActive(false);
            Debug.Log("Bought Mysteltainn");
            PlayerPrefs.SetInt("isMystSold", 1);
        }
        else
        {
            Debug.Log("Not enough Gold");
        }
    }

    public void Buy_Tyrfing()
    {
        if (Gold >= 8000)
        {
            Gold -= 8000;
            tyrf.SetActive(false);
            Debug.Log("Bought Tyrfing");
            PlayerPrefs.SetInt("isTyrfSold", 1);
        }
        else
        {
            Debug.Log("Not enough Gold");
        }
    }

    public void Buy_Grimtooth()
    {
        if (Gold >= 5000)
        {
            Gold -= 5000;
            grim.SetActive(false);
            Debug.Log("Bought Grimtooth");
            PlayerPrefs.SetInt("isGrimSold", 1);
        }
        else
        {
            Debug.Log("Not enough Gold");
        }
    }

    public void Buy_Kamaitachi()
    {
        if (Gold >= 8000)
        {
            Gold -= 8000;
            kamai.SetActive(false);
            Debug.Log("Bought Kamaitachi");
            PlayerPrefs.SetInt("isKamaiSold", 1);
        }
        else
        {
            Debug.Log("Not enough Gold");
        }
    }

    public void Buy_Gun1()
    {
        if (Gold >= 5000)
        {
            Gold -= 5000;
            gun1.SetActive(false);
            Debug.Log("Bought Gun1");
            PlayerPrefs.SetInt("isGun1Sold", 1);
        }
        else
        {
            Debug.Log("Not enough Gold");
        }
    }

    public void Buy_Gun2()
    {
        if (Gold >= 8000)
        {
            Gold -= 8000;
            gun2.SetActive(false);
            Debug.Log("Bought Gun2");
            PlayerPrefs.SetInt("isGun2Sold", 1);
        }
        else
        {
            Debug.Log("Not enough Gold");
        }
    }

    public void Buy_Shirt()
    {
        if (Gold >= 1000)
        {
            Gold -= 1000;
            shirt.SetActive(false);
            Debug.Log("Bought Shirt");
            PlayerPrefs.SetInt("isShirtSold", 1);
        }
        else
        {
            Debug.Log("Not enough Gold");
        }
    }

    public void Buy_Cloak()
    {
        if (Gold >= 4000)
        {
            Gold -= 4000;
            cloak.SetActive(false);
            Debug.Log("Bought Cloak");
            PlayerPrefs.SetInt("isCloakSold", 1);
        }
        else
        {
            Debug.Log("Not enough Gold");
        }
    }

    public void Buy_Cuirass()
    {
        if (Gold >= 4500)
        {
            Gold -= 4500;
            cuirass.SetActive(false);
            Debug.Log("Bought Cuirass");
            PlayerPrefs.SetInt("isCuirassSold", 1);
        }
        else
        {
            Debug.Log("Not enough Gold");
        }
    }

    public void Buy_Plate()
    {
        if (Gold >= 5000)
        {
            Gold -= 5000;
            plate_armor.SetActive(false);
            Debug.Log("Bought Plate Armor");
            PlayerPrefs.SetInt("isPlateSold", 1);
        }
        else
        {
            Debug.Log("Not enough Gold");
        }
    }

    public void Buy_Sandals()
    {
        if (Gold >= 2500)
        {
            Gold -= 2500;
            sandals.SetActive(false);
            Debug.Log("Bought Sandals");
            PlayerPrefs.SetInt("isSandalsSold", 1);
        }
        else
        {
            Debug.Log("Not enough Gold");
        }
    }

    public void Buy_Boots()
    {
        if (Gold >= 3000)
        {
            Gold -= 3000;
            boots.SetActive(false);
            Debug.Log("Bought Leather Boots");
            PlayerPrefs.SetInt("isBootsSold", 1);
        }
        else
        {
            Debug.Log("Not enough Gold");
        }
    }

    public void Buy_Greaves()
    {
        if (Gold >= 3500)
        {
            Gold -= 3500;
            greaves.SetActive(false);
            Debug.Log("Bought Greaves");
            PlayerPrefs.SetInt("isGreavesSold", 1);
        }
        else
        {
            Debug.Log("Not enough Gold");
        }
    }

    void InitializeShop()
    {
        isItem1Sold = PlayerPrefs.GetInt("isMystSold");
        isItem2Sold = PlayerPrefs.GetInt("isTyrfSold");
        isItem3Sold = PlayerPrefs.GetInt("isGrimSold");
        isItem4Sold = PlayerPrefs.GetInt("isKamaiSold");
        isItem5Sold = PlayerPrefs.GetInt("isGun1Sold");
        isItem6Sold = PlayerPrefs.GetInt("isGun2Sold");
        isItem7Sold = PlayerPrefs.GetInt("isShirtSold");
        isItem8Sold = PlayerPrefs.GetInt("isCloakSold");
        isItem9Sold = PlayerPrefs.GetInt("isCuirassSold");
        isItem10Sold = PlayerPrefs.GetInt("isPlateSold");
        isItem11Sold = PlayerPrefs.GetInt("isSandalsSold");
        isItem12Sold = PlayerPrefs.GetInt("isBootsSold");
        isItem13Sold = PlayerPrefs.GetInt("isGreavesSold");

        if(isItem1Sold == 1)
        {
            mystel.SetActive(false);
        }
        if (isItem2Sold == 1)
        {
            tyrf.SetActive(false);
        }
        if (isItem3Sold == 1)
        {
            grim.SetActive(false);
        }
        if (isItem4Sold == 1)
        {
            kamai.SetActive(false);
        }
        if (isItem5Sold == 1)
        {
            gun1.SetActive(false);
        }
        if (isItem6Sold == 1)
        {
            gun2.SetActive(false);
        }
        if (isItem7Sold == 1)
        {
            shirt.SetActive(false);
        }
        if (isItem8Sold == 1)
        {
            cloak.SetActive(false);
        }
        if (isItem9Sold == 1)
        {
            cuirass.SetActive(false);
        }
        if (isItem10Sold == 1)
        {
            plate_armor.SetActive(false);
        }
        if (isItem11Sold == 1)
        {
            sandals.SetActive(false);
        }
        if (isItem12Sold == 1)
        {
            boots.SetActive(false);
        }
        if (isItem13Sold == 1)
        {
            greaves.SetActive(false);
        }
    }
}
