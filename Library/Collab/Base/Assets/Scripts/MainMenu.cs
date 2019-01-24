using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public int initGold;
    public int initHPPotion;
    public int initSPPotion;
    public int initBuffPotion;

    string filename = "save.json";
    string path;

    GameData gameData = new GameData();

    // Use this for initialization
    void Start()
    {
        path = Application.persistentDataPath + "/" + filename;
        Debug.Log(path);
    }

    public void New_Game()
    {
        SceneManager.LoadScene(9);
        New_Game_Init();
    }

    public void Load_Game()
    {
        string contents = System.IO.File.ReadAllText(path);
        gameData = JsonUtility.FromJson<GameData>(contents);
        PlayerPrefs.SetInt("storyProgression", gameData.storyProgression);
        PlayerPrefs.SetInt("MapNo", gameData.MapNo);
        PlayerPrefs.SetInt("CharacterNo", gameData.CharacterNo);
        PlayerPrefs.SetInt("CurrentGold", gameData.CurrentGold);
        PlayerPrefs.SetInt("CurrentHPPotion", gameData.CurrentHPPotion);
        PlayerPrefs.SetInt("CurrentSPPotion", gameData.CurrentSPPotion);
        PlayerPrefs.SetInt("CurrentAtkBuff", gameData.CurrentAtkBuff);
        PlayerPrefs.SetInt("CurrentDefBuff", gameData.CurrentDefBuff);
        PlayerPrefs.SetInt("CurrentEnchantB", gameData.CurrentEnchantB);
        PlayerPrefs.SetInt("CurrentEnchantI", gameData.CurrentEnchantI);
        PlayerPrefs.SetInt("isMystSold", gameData.isMystSold);
        PlayerPrefs.SetInt("isTyrfSold", gameData.isTyrfSold);
        PlayerPrefs.SetInt("isGrimSold", gameData.isGrimSold);
        PlayerPrefs.SetInt("isKamaiSold", gameData.isKamaiSold);
        PlayerPrefs.SetInt("isGun1Sold", gameData.isGun1Sold);
        PlayerPrefs.SetInt("isGun2Sold", gameData.isGun2Sold);
        PlayerPrefs.SetInt("isShirtSold", gameData.isShirtSold);
        PlayerPrefs.SetInt("isCloakSold", gameData.isCloakSold);
        PlayerPrefs.SetInt("isCuirassSold", gameData.isCuirassSold);
        PlayerPrefs.SetInt("isPlateSold", gameData.isPlateSold);
        PlayerPrefs.SetInt("isSandalsSold", gameData.isSandalsSold);
        PlayerPrefs.SetInt("isBootsSold", gameData.isBootsSold);
        PlayerPrefs.SetInt("isGreavesSold", gameData.isGreavesSold);
        PlayerPrefs.SetInt("weaponXylia", gameData.weaponXylia);
        PlayerPrefs.SetInt("armorXylia", gameData.armorXylia);
        PlayerPrefs.SetInt("bootsXylia", gameData.bootsXylia);
        PlayerPrefs.SetInt("weaponStar", gameData.weaponStar);
        PlayerPrefs.SetInt("armorStar", gameData.armorStar);
        PlayerPrefs.SetInt("bootsStar", gameData.bootsStar);
        PlayerPrefs.SetInt("weaponRoc", gameData.weaponRoc);
        PlayerPrefs.SetInt("armorRoc", gameData.armorRoc);
        PlayerPrefs.SetInt("bootsRoc", gameData.bootsRoc);
        PlayerPrefs.SetInt("level", gameData.level);
        PlayerPrefs.SetInt("exp", gameData.exp);
        PlayerPrefs.SetInt("exp_cap", gameData.exp_cap);
        PlayerPrefs.SetInt("maxHP_Xylia", gameData.maxHP_Xylia);
        PlayerPrefs.SetInt("maxSP_Xylia", gameData.maxSP_Xylia);
        PlayerPrefs.SetInt("atk_Xylia", gameData.atk_Xylia);
        PlayerPrefs.SetInt("def_Xylia", gameData.def_Xylia);
        PlayerPrefs.SetInt("spd_Xylia", gameData.spd_Xylia);
        PlayerPrefs.SetInt("maxHP_Star", gameData.maxHP_Star);
        PlayerPrefs.SetInt("maxSP_Star", gameData.maxSP_Star);
        PlayerPrefs.SetInt("atk_Star", gameData.atk_Star);
        PlayerPrefs.SetInt("def_Star", gameData.def_Star);
        PlayerPrefs.SetInt("spd_Star", gameData.spd_Star);
        PlayerPrefs.SetInt("maxHP_Roc", gameData.maxHP_Roc);
        PlayerPrefs.SetInt("maxSP_Roc", gameData.maxSP_Roc);
        PlayerPrefs.SetInt("atk_Roc", gameData.atk_Roc);
        PlayerPrefs.SetInt("def_Roc", gameData.def_Roc);
        PlayerPrefs.SetInt("spd_Roc", gameData.spd_Roc);
        PlayerPrefs.SetInt("enemyArrow", gameData.enemyArrow);
        Debug.Log("Load Game!");
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Debug.Log("Game Exited!");
    }

    public void New_Game_Init()
    {
        PlayerPrefs.SetInt("storyProgression", 0);
        PlayerPrefs.SetInt("MapNo", 0);
        PlayerPrefs.SetInt("CharacterNo", 0);
        PlayerPrefs.SetInt("CurrentGold", initGold);
        PlayerPrefs.SetInt("CurrentHPPotion", initHPPotion);
        PlayerPrefs.SetInt("CurrentSPPotion", initSPPotion);
        PlayerPrefs.SetInt("CurrentAtkBuff", initBuffPotion);
        PlayerPrefs.SetInt("CurrentDefBuff", initBuffPotion);
        PlayerPrefs.SetInt("CurrentEnchantB", 0);
        PlayerPrefs.SetInt("CurrentEnchantI", 0);
        PlayerPrefs.SetInt("isMystSold", 0);
        PlayerPrefs.SetInt("isTyrfSold", 0);
        PlayerPrefs.SetInt("isGrimSold", 0);
        PlayerPrefs.SetInt("isKamaiSold", 0);
        PlayerPrefs.SetInt("isGun1Sold", 0);
        PlayerPrefs.SetInt("isGun2Sold", 0);
        PlayerPrefs.SetInt("isShirtSold", 0);
        PlayerPrefs.SetInt("isCloakSold", 0);
        PlayerPrefs.SetInt("isCuirassSold", 0);
        PlayerPrefs.SetInt("isPlateSold", 0);
        PlayerPrefs.SetInt("isSandalsSold", 0);
        PlayerPrefs.SetInt("isBootsSold", 0);
        PlayerPrefs.SetInt("isGreavesSold", 0);
        PlayerPrefs.SetInt("weaponXylia", 0);
        PlayerPrefs.SetInt("armorXylia", 0);
        PlayerPrefs.SetInt("bootsXylia", 0);
        PlayerPrefs.SetInt("weaponStar", 0);
        PlayerPrefs.SetInt("armorStar", 0);
        PlayerPrefs.SetInt("bootsStar", 0);
        PlayerPrefs.SetInt("weaponRoc", 0);
        PlayerPrefs.SetInt("armorRoc", 0);
        PlayerPrefs.SetInt("bootsRoc", 0);
        PlayerPrefs.SetInt("level", 1);
        PlayerPrefs.SetInt("exp", 0);
        PlayerPrefs.SetInt("exp_cap", 100);
        PlayerPrefs.SetInt("maxHP_Xylia", 400);
        PlayerPrefs.SetInt("maxSP_Xylia", 100);
        PlayerPrefs.SetInt("atk_Xylia", 100);
        PlayerPrefs.SetInt("def_Xylia", 40);
        PlayerPrefs.SetInt("spd_Xylia", 25);
        PlayerPrefs.SetInt("maxHP_Star", 350);
        PlayerPrefs.SetInt("maxSP_Star", 50);
        PlayerPrefs.SetInt("atk_Star", 110);
        PlayerPrefs.SetInt("def_Star", 20);
        PlayerPrefs.SetInt("spd_Star", 30);
        PlayerPrefs.SetInt("maxHP_Roc", 410);
        PlayerPrefs.SetInt("maxSP_Roc", 10);
        PlayerPrefs.SetInt("atk_Roc", 70);
        PlayerPrefs.SetInt("def_Roc", 30);
        PlayerPrefs.SetInt("spd_Roc", 35);
        PlayerPrefs.SetInt("enemyArrow", 0);
    }
}
