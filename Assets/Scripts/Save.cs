using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour {

    public GameObject hub_menu;
    public GameObject save_menu;

    string filename = "save.json";
    string path;

    GameData gameData = new GameData();

    // Use this for initialization
    void Start()
    {
        path = Application.persistentDataPath + "/" + filename;
        Debug.Log(path);
    }

    public void SavePress()
    {
        gameData.storyProgression = PlayerPrefs.GetInt("storyProgression");
        gameData.MapNo = PlayerPrefs.GetInt("MapNo");
        gameData.CharacterNo = PlayerPrefs.GetInt("CharacterNo");
        gameData.CurrentGold = PlayerPrefs.GetInt("CurrentGold");
        gameData.CurrentHPPotion = PlayerPrefs.GetInt("CurrentHPPotion");
        gameData.CurrentSPPotion = PlayerPrefs.GetInt("CurrentSPPotion");
        gameData.CurrentAtkBuff = PlayerPrefs.GetInt("CurrentAtkBuff");
        gameData.CurrentDefBuff = PlayerPrefs.GetInt("CurrentDefBuff");
        gameData.CurrentEnchantB = PlayerPrefs.GetInt("CurrentEnchantB");
        gameData.CurrentEnchantI = PlayerPrefs.GetInt("CurrentEnchantI");
        gameData.isMystSold = PlayerPrefs.GetInt("isMystSold");
        gameData.isTyrfSold = PlayerPrefs.GetInt("isTyrfSold");
        gameData.isGrimSold = PlayerPrefs.GetInt("isGrimSold");
        gameData.isKamaiSold = PlayerPrefs.GetInt("isKamaiSold");
        gameData.isGun1Sold = PlayerPrefs.GetInt("isGun1Sold");
        gameData.isGun2Sold = PlayerPrefs.GetInt("isGun2Sold");
        gameData.isShirtSold = PlayerPrefs.GetInt("isShirtSold");
        gameData.isCloakSold = PlayerPrefs.GetInt("isCloakSold");
        gameData.isCuirassSold = PlayerPrefs.GetInt("isCuirassSold");
        gameData.isPlateSold = PlayerPrefs.GetInt("isPlateSold");
        gameData.isSandalsSold = PlayerPrefs.GetInt("isSandalsSold");
        gameData.isBootsSold = PlayerPrefs.GetInt("isBootsSold");
        gameData.isGreavesSold = PlayerPrefs.GetInt("isGreavesSold");
        gameData.weaponXylia = PlayerPrefs.GetInt("weaponXylia");
        gameData.armorXylia = PlayerPrefs.GetInt("armorXylia");
        gameData.bootsXylia = PlayerPrefs.GetInt("bootsXylia");
        gameData.weaponStar = PlayerPrefs.GetInt("weaponStar");
        gameData.armorStar = PlayerPrefs.GetInt("armorStar");
        gameData.bootsStar = PlayerPrefs.GetInt("bootsStar");
        gameData.weaponRoc = PlayerPrefs.GetInt("weaponRoc");
        gameData.armorRoc = PlayerPrefs.GetInt("armorRoc");
        gameData.bootsRoc = PlayerPrefs.GetInt("bootsRoc");
        gameData.level = PlayerPrefs.GetInt("level");
        gameData.exp = PlayerPrefs.GetInt("exp");
        gameData.exp_cap = PlayerPrefs.GetInt("exp_cap");
        gameData.maxHP_Xylia = PlayerPrefs.GetInt("maxHP_Xylia");
        gameData.maxSP_Xylia = PlayerPrefs.GetInt("maxSP_Xylia");
        gameData.atk_Xylia = PlayerPrefs.GetInt("atk_Xylia");
        gameData.def_Xylia = PlayerPrefs.GetInt("def_Xylia");
        gameData.spd_Xylia = PlayerPrefs.GetInt("spd_Xylia");
        gameData.maxHP_Star = PlayerPrefs.GetInt("maxHP_Star");
        gameData.maxSP_Star = PlayerPrefs.GetInt("maxSP_Star");
        gameData.atk_Star = PlayerPrefs.GetInt("atk_Star");
        gameData.def_Star = PlayerPrefs.GetInt("def_Star");
        gameData.spd_Star = PlayerPrefs.GetInt("spd_Star");
        gameData.maxHP_Roc = PlayerPrefs.GetInt("maxHP_Roc");
        gameData.maxSP_Roc = PlayerPrefs.GetInt("maxSP_Roc");
        gameData.atk_Roc = PlayerPrefs.GetInt("atk_Roc");
        gameData.def_Roc = PlayerPrefs.GetInt("def_Roc");
        gameData.spd_Roc = PlayerPrefs.GetInt("spd_Roc");
        SaveData();
    }

    public void SaveData()
    {
        string contents = JsonUtility.ToJson(gameData, true);
        System.IO.File.WriteAllText(path, contents);
        Debug.Log("Game Saved!");
    }
    public void Save_Back()
    {
        save_menu.SetActive(false);
        hub_menu.SetActive(true);
    }
}
