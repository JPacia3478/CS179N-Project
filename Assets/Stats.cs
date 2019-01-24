using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour {
    public Text lvlText;
    public Text HPText;
    public Text SPText;
    public Text AtkText;
    public Text DefText;
    public Text SpdText;

    public int Level;
    public int HP_X;
    public int HP_S;
    public int HP_R;
    public int SP_X;
    public int SP_S;
    public int SP_R;
    public int Atk_X;
    public int Atk_S;
    public int Atk_R;
    public int Def_X;
    public int Def_S;
    public int Def_R;
    public int Spd_X;
    public int Spd_S;
    public int Spd_R;
    public int characterno;

    public bool get_Equip;
    public int weaponNumberXylia;
    public int armorNumberXylia;
    public int bootsNumberXylia;
    public int weaponNumberStar;
    public int armorNumberStar;
    public int bootsNumberStar;
    public int weaponNumberRoc;
    public int armorNumberRoc;
    public int bootsNumberRoc;

    public void updateHP()
    {
        HPText.text = "HP     " + PlayerPrefs.GetInt("currHP");
        /*if (characterno == 1)
        {
            HPText.text = "HP     " + HP_X;
        }
        else if (characterno == 2)
        {
            HPText.text = "HP     " + HP_S;
        }
        else if (characterno == 3)
        {
            HPText.text = "HP     " + HP_R;
        }*/
    }

    public void updateSP()
    {
        SPText.text = "SP    " + PlayerPrefs.GetInt("currSP");
        /*if (characterno == 1)
        {
            SPText.text = "SP     " + SP_X;
        }
        else if (characterno == 2)
        {
            SPText.text = "SP     " + SP_S;
        }
        else if (characterno == 3)
        {
            SPText.text = "SP     " + SP_R;
        }*/
    }

    public void updateLevel()
    {
        lvlText.text = "Level " + Level;
    }

    public void updateAtk()
    {
        AtkText.text = "Attack    " + PlayerPrefs.GetInt("currAtk");
        /*if (characterno == 1)
        {
            AtkText.text = "Attack    " + Atk_X;
        }
        else if (characterno == 2)
        {
            AtkText.text = "Attack    " + Atk_S;
        }
        else if (characterno == 3)
        {
            AtkText.text = "Attack    " + Atk_R;
        }*/
    }

    public void updateDef()
    {
        DefText.text = "Defense   " + PlayerPrefs.GetInt("currDef");
        /*if (characterno == 1)
        {
            DefText.text = "Defense   " + Def_X;
        }
        else if (characterno == 2)
        {
            DefText.text = "Defense   " + Def_S;
        }
        else if (characterno == 3)
        {
            DefText.text = "Defense   " + Def_R;
        }*/
    }

    public void updateSpd()
    {
        SpdText.text = "Speed     " + PlayerPrefs.GetInt("currSpd");
        /*if (characterno == 1)
        {
            SpdText.text = "Speed     " + Spd_X;
        }
        else if (characterno == 2)
        {
            SpdText.text = "Speed     " + Spd_S;
        }
        else if (characterno == 3)
        {
            SpdText.text = "Speed     " + Spd_R;
        }*/
    }

    //Initialization
    void Start()
    {
        get_Equip = true;
        Level = PlayerPrefs.GetInt("level");

        HP_X = PlayerPrefs.GetInt("maxHP_Xylia");
        SP_X = PlayerPrefs.GetInt("maxSP_Xylia");
        Atk_X = PlayerPrefs.GetInt("atk_Xylia");
        Def_X = PlayerPrefs.GetInt("def_Xylia");
        Spd_X = PlayerPrefs.GetInt("spd_Xylia");

        HP_S = PlayerPrefs.GetInt("maxHP_Star");
        SP_S = PlayerPrefs.GetInt("maxSP_Star");
        Atk_S = PlayerPrefs.GetInt("atk_Star");
        Def_S = PlayerPrefs.GetInt("def_Star");
        Spd_S = PlayerPrefs.GetInt("spd_Star");

        HP_R = PlayerPrefs.GetInt("maxHP_Roc");
        SP_R = PlayerPrefs.GetInt("maxSP_Roc");
        Atk_R = PlayerPrefs.GetInt("atk_Roc");
        Def_R = PlayerPrefs.GetInt("def_Roc");
        Spd_R = PlayerPrefs.GetInt("spd_Roc");
    }

    // Update is called once per frame
    void Update () {
        characterno = PlayerPrefs.GetInt("CharacterNo");
        updateLevel();
        updateHP();
        updateSP();
        updateAtk();
        updateDef();
        updateSpd();
        GetEquipmentInfo();

	}

    void GetEquipmentInfo()
    {
        weaponNumberXylia = PlayerPrefs.GetInt("weaponXylia");
        armorNumberXylia = PlayerPrefs.GetInt("armorXylia");
        bootsNumberXylia = PlayerPrefs.GetInt("bootsXylia");
        weaponNumberStar = PlayerPrefs.GetInt("weaponStar");
        armorNumberStar = PlayerPrefs.GetInt("armorStar");
        bootsNumberStar = PlayerPrefs.GetInt("bootsStar");
        weaponNumberRoc = PlayerPrefs.GetInt("weaponRoc");
        armorNumberRoc = PlayerPrefs.GetInt("armorRoc");
        bootsNumberRoc = PlayerPrefs.GetInt("bootsRoc");
        if (get_Equip)
        {
            if (weaponNumberXylia == 0)
            {

            }
            else if (weaponNumberXylia == 1)
            {
                Atk_X = Atk_X + 120;
            }
            else if (weaponNumberXylia == 2)
            {
                Atk_X = Atk_X + 250;
            }
            if (armorNumberXylia == 0)
            {

            }
            else if (armorNumberXylia == 1)
            {
                Def_X = Def_X + 50;
            }
            else if (armorNumberXylia == 2)
            {
                Def_X = Def_X + 100;
            }
            if (bootsNumberXylia == 0)
            {

            }
            else if (bootsNumberXylia == 1)
            {
                Atk_X = Atk_X + 30;
                Def_X = Def_X + 10;
            }
            if (weaponNumberStar == 0)
            {

            }
            else if (weaponNumberStar == 1)
            {
                Atk_S = Atk_S + 200;
            }
            else if (weaponNumberStar == 2)
            {
                Atk_S = Atk_S + 350;
            }
            if (armorNumberStar == 0)
            {

            }
            else if (armorNumberStar == 1)
            {
                Def_S = Def_S + 20;
            }
            else if (armorNumberStar == 2)
            {
                Def_S = Def_S + 40;
            }
            if (bootsNumberStar == 0)
            {

            }
            else if (bootsNumberStar == 1)
            {
                Atk_S = Atk_S + 35;
                Def_S = Def_S + 5;
            }
            if (weaponNumberRoc == 0)
            {

            }
            else if (weaponNumberRoc == 1)
            {
                Atk_R = Atk_R + 100;
            }
            else if (weaponNumberRoc == 2)
            {
                Atk_R = Atk_R + 220;
            }
            if (armorNumberRoc == 0)
            {

            }
            else if (armorNumberRoc == 1)
            {
                Def_R = Def_R + 30;
            }
            else if (armorNumberRoc == 2)
            {
                Def_R = Def_R + 55;
            }
            if (bootsNumberRoc == 0)
            {

            }
            else if (bootsNumberRoc == 1)
            {
                Atk_R = Atk_R + 40;
            }
            get_Equip = false;
        }
    }
}
