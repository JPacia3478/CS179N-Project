using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour {
    
    public Text hp_pot;
    public Text sp_pot;
    public Text atk_pot;
    public Text def_pot;
    public Text burn_pot;
    public Text immobile_pot;

    public int hp_potion_cnt;
    public int sp_potion_cnt;
    public int atk_buff_cnt;
    public int def_buff_cnt;
    public int enchantB_cnt;
    public int enchantI_cnt;

    public int character_no;
    public GameObject player;
    //public bool slotIsEmpty = true;
    //public GameObject itemIcon;
    //public GameObject xButton;

    //public int itemNo = 0;
    //public int buffAmount = 0;

	// Use this for initialization
	void Start () {
        character_no = PlayerPrefs.GetInt("CharacterNo");
        hp_potion_cnt = PlayerPrefs.GetInt("CurrentHPPotion");
        sp_potion_cnt = PlayerPrefs.GetInt("CurrentSPPotion");
        atk_buff_cnt = PlayerPrefs.GetInt("CurrentAtkBuff");
        def_buff_cnt = PlayerPrefs.GetInt("CurrentDefBuff");
        enchantB_cnt = PlayerPrefs.GetInt("CurrentEnchantB");
        enchantI_cnt = PlayerPrefs.GetInt("CurrentEnchantI");
    }
	
	// Update is called once per frame
	void Update () {
        hp_potion_cnt = PlayerPrefs.GetInt("CurrentHPPotion");
        sp_potion_cnt = PlayerPrefs.GetInt("CurrentSPPotion");
        atk_buff_cnt = PlayerPrefs.GetInt("CurrentAtkBuff");
        def_buff_cnt = PlayerPrefs.GetInt("CurrentDefBuff");
        enchantB_cnt = PlayerPrefs.GetInt("CurrentEnchantB");
        enchantI_cnt = PlayerPrefs.GetInt("CurrentEnchantI");
        hp_pot.text = "Healing Potion " + hp_potion_cnt + "x";
        sp_pot.text = "SP Potion " + sp_potion_cnt + "x";
        atk_pot.text = "Atk Buff " + atk_buff_cnt + "x";
        def_pot.text = "Def Buff " + def_buff_cnt + "x";
        burn_pot.text = "Enchant Burn " + enchantB_cnt + "x";
        immobile_pot.text = "Enchant Immobile " + enchantI_cnt + "x";
    }

    /*public void healthPot()
    {
        if(hp_potion_cnt > 0)
        {
            hp_potion_cnt--;
            if(character_no == 1)
            {
                SendMessageUpwards("heal_X", 150);
            }
            else if(character_no == 2)
            {
                SendMessageUpwards("heal_S", 150);
            }
            else if(character_no == 3)
            {
                SendMessageUpwards("heal_R", 150);
            }
        }
    }*/

    /*public void addItem(int number, int amount)
    {
        if (slotIsEmpty)
        {
            xButton.SetActive(true);
            itemIcon.SetActive(true);
            itemNo = number;
            buffAmount = amount;
            slotIsEmpty = false;
        }
    }

    public void useItem()
    {
        if (slotIsEmpty == false)
        {
            xButton.SetActive(false);
            itemIcon.SetActive(false);
            if (itemNo == 1)
            {
                player.GetComponent<MainCharacter>().currentHP += buffAmount;
            }
            else if (itemNo == 2)
            {
                player.GetComponent<MainCharacter>().currentSP += buffAmount;
            }
            else
            {
                Debug.Log("invalid item");
                return;
            }
            itemNo = 0;
            buffAmount = 0;
            slotIsEmpty = true;
        }
    }

    public void removeItem()
    {
        if (slotIsEmpty == false)
        {
            xButton.SetActive(false);
            itemIcon.SetActive(false);
            //player.GetComponent<MainCharacter>().Atk -= 2;
            itemNo = 0;
            buffAmount = 0;
            slotIsEmpty = true;
        }
    }*/
}
