using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainCharacter : MonoBehaviour
{
    //attributes + UI texts 
    public int Level;
    public Text lvlText;
    public int Exp;
    public Text currExp;
    public int ExpCap;
    public Text nxtLvl;
    public int Gold;
    public Text goldText;
    public int maxHP_X;
    public int maxHP_S;
    public int maxHP_R;
    public int HP_X;
    public int HP_S;
    public int HP_R;
    public int currentHP;
    public Text HPText;
    public int maxSP_X;
    public int maxSP_S;
    public int maxSP_R;
    public int SP_X;
    public int SP_S;
    public int SP_R;
    public int currentSP;
    public Text SPText;
    public int Atk_X;
    public int Atk_S;
    public int Atk_R;
    public Text AtkText;
    public int Def_X;
    public int Def_S;
    public int Def_R;
    public Text DefText;
    public int Spd_X;
    public int Spd_S;
    public int Spd_R;
    public Text SpdText;

    //character switching variables
    public Sprite XyliaSprite;
    public Sprite StarSprite;
    public Sprite RocSprite;
    public RuntimeAnimatorController XyliaAnimation;
    public RuntimeAnimatorController StarAnimation;
    public RuntimeAnimatorController RocAnimation;
    public Text characterName;

    //battle variables
    public int characterno;
    public bool alive;
    public bool active;
    public bool attacking;
    private float attackTime = 0;
    private float attackDelay = 0.5f;
    public bool defeat;
    public bool hit;
    public bool invuln;
    public int invulCount;
    public bool dtime_start;
    public float deathTimer = 0;
    public float deathDelay = 1.5f;
    public int statusno;
    public int map_no;

    //movement variables
    private bool facingRight = true;
    public float speed;

    //colliders and animation
    private Rigidbody2D player;
    public Collider2D HitBox;
    private Animator animator;

    //ranged variables
    public GameObject arrow;
    public GameObject trap;
    public float arrowSpeed;

    public static string logFile;

    //equipment variables
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

    public int hp_potion_cnt;
    public int sp_potion_cnt;
    public int atk_buff_cnt;
    public int def_buff_cnt;
    public int enchantB_cnt;
    public int enchantI_cnt;
    public int HPpot = 150;             //Item values initialization
    public int SPpot = 100;

    public bool isABuffed;
    public int ATKbuff = 50;
    public float aBuff_start;
    public float aBuff_delay = 7.5f;

    public bool isDBuffed;
    public int DEFbuff = 50;
    public float dBuff_start;
    public float dBuff_delay = 7.5f;

    public bool isEnchantB;
    public float enchantBurn_s;
    public float enchantBurn_d = 10f;

    public bool isEnchantI;
    public float enchantImmobile_s;
    public float enchantImmobile_d = 10f;


    public GameObject gameOverUI;

    // Phase shift variables
    public bool isInPhaseShift;
    public int phaseShiftCost;
    public float phaseShiftCool = 10;
    public float phaseShiftCnt;
    public float phaseShiftDelay = 5;
    public GameObject MainCharacters;

    // Fade variables
    public bool isInFade;
    public int fadeCost;
    public float fadeCool = 10;
    public float fadeCnt;

    // Concealment variables
    public static bool isConcealed;
    public static float timeOutOfCombat = 4;
    public static float concealTimeCnt;
    public static float concealCoolCnt;
    public static float concealCool = 10;
    public float a_concealed;
    public float a_regular;
    public Color mainCharacterColor;

    // trap variables
    public bool isTrap;
    public int trapCost;
    public float trapCnt;
    public float trapCool = 3;

    public void levelUp()
    {
        Level++;
        lvlText.text = "Level " + Level;
        PlayerPrefs.SetInt("level", Level);
        maxHP_X += 90;
        PlayerPrefs.SetInt("maxHP_Xylia", maxHP_X);
        maxHP_S += 40;
        PlayerPrefs.SetInt("maxHP_Star", maxHP_S);
        maxHP_R += 60;
        PlayerPrefs.SetInt("maxHP_Roc", maxHP_R);
        HP_X = PlayerPrefs.GetInt("maxHP_Xylia");
        HP_S = PlayerPrefs.GetInt("maxHP_Star");
        HP_R = PlayerPrefs.GetInt("maxHP_Roc");
        maxSP_X += 25;
        PlayerPrefs.SetInt("maxSP_Xylia", maxSP_X);
        maxSP_S += 20;
        PlayerPrefs.SetInt("maxSP_Star", maxSP_S);
        maxSP_R += 10;
        PlayerPrefs.SetInt("maxSP_Roc", maxSP_R);
        Atk_X += 15;
        PlayerPrefs.SetInt("atk_Xylia", Atk_X);
        Atk_S += 25;
        PlayerPrefs.SetInt("atk_Star", Atk_S);
        Atk_R += 20;
        PlayerPrefs.SetInt("atk_Roc", Atk_R);
        Def_X += 5;
        PlayerPrefs.SetInt("def_Xylia", Def_X);
        Def_S += 1;
        PlayerPrefs.SetInt("def_Star", Def_S);
        Def_R += 3;
        PlayerPrefs.SetInt("def_Roc", Def_R);
        //Spd += 5;
        //PlayerPrefs.SetInt("spd_Xylia", Spd);
    }
    public void updateHP()
    {
        if (characterno == 1)
        {
            HPText.text = "HP     " + HP_X;
            PlayerPrefs.SetInt("currHP", HP_X);
        }
        else if (characterno == 2)
        {
            HPText.text = "HP     " + HP_S;
            PlayerPrefs.SetInt("currHP", HP_S);
        }
        else if (characterno == 3)
        {
            HPText.text = "HP     " + HP_R;
            PlayerPrefs.SetInt("currHP", HP_R);
        }
    }
    public void updateSP()
    {
        if (characterno == 1)
        {
            SPText.text = "SP     " + SP_X;
            PlayerPrefs.SetInt("currSP", SP_X);
        }
        else if (characterno == 2)
        {
            SPText.text = "SP     " + SP_S;
            PlayerPrefs.SetInt("currSP", SP_S);
        }
        else if (characterno == 3)
        {
            SPText.text = "SP     " + SP_R;
            PlayerPrefs.SetInt("currSP", SP_R);
        }
    }
    public void updateLevel()
    {
        lvlText.text = "Level " + Level;
    }
    public void updateNextLevel()
    {
        if ((ExpCap - Exp) > 0)
            nxtLvl.text = "Next Level     " + (ExpCap - Exp);
        else
            nxtLvl.text = "Next Level     " + (0);
    }
    public void updateAtk()
    {
        if (characterno == 1)
        {
            AtkText.text = "Attack    " + Atk_X;
            PlayerPrefs.SetInt("currAtk", Atk_X);
        }
        else if (characterno == 2)
        {
            AtkText.text = "Attack    " + Atk_S;
            PlayerPrefs.SetInt("currAtk", Atk_S);
        }
        else if (characterno == 3)
        {
            AtkText.text = "Attack    " + Atk_R;
            PlayerPrefs.SetInt("currAtk", Atk_R);
        }
    }
    public void updateDef()
    {
        if (characterno == 1)
        {
            DefText.text = "Defense   " + Def_X;
            PlayerPrefs.SetInt("currDef", Def_X);
        }
        else if (characterno == 2)
        {
            DefText.text = "Defense   " + Def_S;
            PlayerPrefs.SetInt("currDef", Def_S);
        }
        else if (characterno == 3)
        {
            DefText.text = "Defense   " + Def_R;
            PlayerPrefs.SetInt("currDef", Def_R);
        }
    }
    public void updateSpd()
    {
        if (characterno == 1)
        {
            SpdText.text = "Speed     " + Spd_X;
            PlayerPrefs.SetInt("currSpd", Spd_X);
        }
        else if (characterno == 2)
        {
            SpdText.text = "Speed     " + Spd_S;
            PlayerPrefs.SetInt("currSpd", Spd_S);
        }
        else if (characterno == 3)
        {
            SpdText.text = "Speed     " + Spd_R;
            PlayerPrefs.SetInt("currSpd", Spd_R);
        }
    }
    public void enemyDefeated(int attackerExp)
    {
        Exp += attackerExp;
        PlayerPrefs.SetInt("exp", Exp);
        if (Exp >= ExpCap)
        {
            Exp -= ExpCap;
            if (Exp < 0)
            {
                Exp = 0;
            }
            ExpCap += 100;
            PlayerPrefs.SetInt("exp_cap", ExpCap);
            levelUp();
        }
    }

    public void addGold(int g)
    {
        Gold += g;
        PlayerPrefs.SetInt("CurrentGold", Gold);
    }

    public void gotHit(int attacker)
    {
        if (!invuln)
        {
            if (characterno == 1)
            {
                if (attacker < Def_X)
                {
                    Debug.Log("No Damage");
                    return;
                }
                else
                {
                    HP_X -= attacker - Def_X;
                    currentHP = HP_X;
                }
            }
            else if (characterno == 2)
            {
                if (attacker < Def_S)
                {
                    Debug.Log("No Damage");
                    return;
                }
                else
                {
                    HP_S -= attacker - Def_S;
                    currentHP = HP_S;
                }
            }
            else if (characterno == 3)
            {
                concealTimeCnt = timeOutOfCombat;
                if (isConcealed == true)
                {
                    isConcealed = false;
                    changeRocVisibility();
                    concealCoolCnt = concealCool;
                }
                if (attacker < Def_R || isInFade == true)
                {
                    Debug.Log("No Damage");
                    if (isInFade == true)
                    {
                        isInFade = false;
                        fadeCnt = fadeCool;
                    }
                    return;
                }
                else
                {
                    HP_R -= attacker - Def_R;
                    currentHP = HP_R;
                }
                if (isInFade == true)
                {
                    isInFade = false;
                    fadeCnt = fadeCool;
                }
            }
            invuln = true;
            Debug.Log("Player Damage Taken");
        }
    }

    // Use this for initialization
    void Start()
    {

        map_no = PlayerPrefs.GetInt("MapNo");
        if(map_no == 6 || map_no == 7 || map_no == 8)
        {
            Time.timeScale = 1f;
        }
        Level = PlayerPrefs.GetInt("level");
        Exp = PlayerPrefs.GetInt("exp");
        ExpCap = PlayerPrefs.GetInt("exp_cap");

        // Xylia Initialize
        maxHP_X = PlayerPrefs.GetInt("maxHP_Xylia");
        HP_X = PlayerPrefs.GetInt("maxHP_Xylia");
        currentHP = HP_X;
        maxSP_X = PlayerPrefs.GetInt("maxSP_Xylia");
        SP_X = PlayerPrefs.GetInt("maxSP_Xylia");
        currentSP = SP_X;
        Atk_X = PlayerPrefs.GetInt("atk_Xylia");
        Def_X = PlayerPrefs.GetInt("def_Xylia");
        Spd_X = PlayerPrefs.GetInt("spd_Xylia");
        speed = Spd_X / 5;

        // Star Initialize
        maxHP_S = PlayerPrefs.GetInt("maxHP_Star");
        HP_S = PlayerPrefs.GetInt("maxHP_Star");
        maxSP_S = PlayerPrefs.GetInt("maxSP_Star");
        SP_S = PlayerPrefs.GetInt("maxSP_Star");
        Atk_S = PlayerPrefs.GetInt("atk_Star");
        Def_S = PlayerPrefs.GetInt("def_Star");
        Spd_S = PlayerPrefs.GetInt("spd_Star");
        speed = Spd_S / 5;

        // Roc Initialize
        maxHP_R = PlayerPrefs.GetInt("maxHP_Roc");
        HP_R = PlayerPrefs.GetInt("maxHP_Roc");
        maxSP_R = PlayerPrefs.GetInt("maxSP_Roc");
        SP_R = PlayerPrefs.GetInt("maxSP_Roc");
        Atk_R = PlayerPrefs.GetInt("atk_Roc");
        Def_R = PlayerPrefs.GetInt("def_Roc");
        Spd_R = PlayerPrefs.GetInt("spd_Roc");
        speed = Spd_R / 5;

        Gold = PlayerPrefs.GetInt("CurrentGold");
        get_Equip = true;
        hp_potion_cnt = PlayerPrefs.GetInt("CurrentHPPotion");
        sp_potion_cnt = PlayerPrefs.GetInt("CurrentSPPotion");
        atk_buff_cnt = PlayerPrefs.GetInt("CurrentAtkBuff");
        def_buff_cnt = PlayerPrefs.GetInt("CurrentDefBuff");
        enchantB_cnt = PlayerPrefs.GetInt("CurrentEnchantB");
        enchantI_cnt = PlayerPrefs.GetInt("CurrentEnchantI");

        characterno = 1;
        alive = true;
        active = true;
        attacking = false;
        defeat = false;
        hit = false;
        invuln = false;
        invulCount = 0;
        HitBox.enabled = false;
        arrowSpeed = 1000;
        dtime_start = false;
        statusno = 0;

        player = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        // set phase shift variables
        isInPhaseShift = false;
        phaseShiftCost = 50;

        // set fade variables
        isInFade = false;
        fadeCost = 50;

        // set concealment variables
        isConcealed = false;
        a_concealed = 0.5f;
        a_regular = 1;

        // set trap variables
        isTrap = false;
        trapCost = 30;
    }

    // Update is called once per frame
    void Update()
    {
        //UI updates
        speed = Spd_X / 5;
        updateHP();
        updateSP();
        updateLevel();
        goldText.text = "Gold " + Gold;
        currExp.text = "Experience     " + Exp;
        updateNextLevel();
        updateAtk();
        updateDef();
        updateSpd();
        GetEquipmentInfo();
        characterno = PlayerPrefs.GetInt("CharacterNo");
        //switching characters
        if (Input.GetKeyDown("z") && characterno != 1)
        {
            characterno = 1;
            currentHP = HP_X;
            currentSP = SP_X;
            characterName.text = "Xylia";
            this.gameObject.GetComponent<SpriteRenderer>().sprite = XyliaSprite;
            this.gameObject.GetComponent<Animator>().runtimeAnimatorController = XyliaAnimation;
        }
        if (Input.GetKeyDown("x") && characterno != 2)
        {
            characterno = 2;
            currentHP = HP_S;
            currentSP = SP_S;
            characterName.text = "Star";
            this.gameObject.GetComponent<SpriteRenderer>().sprite = StarSprite;
            this.gameObject.GetComponent<Animator>().runtimeAnimatorController = StarAnimation;
        }
        if (Input.GetKeyDown("c") && characterno != 3)
        {
            characterno = 3;
            currentHP = HP_R;
            currentSP = SP_R;
            characterName.text = "Roc";
            this.gameObject.GetComponent<SpriteRenderer>().sprite = RocSprite;
            this.gameObject.GetComponent<Animator>().runtimeAnimatorController = RocAnimation;
        }
        PlayerPrefs.SetInt("CharacterNo", characterno);

        //movement and attacking
        if (Input.GetKeyDown("l") && !attacking && characterno != 2)
        {
            attacking = true;
            attackTime = attackDelay;
            HitBox.enabled = true;

            animator.SetTrigger("FemaleAttack");
            CharacterSoundManager.PlaySound("XyliaAttack1");
            //gotHit();
        }
        else if (Input.GetButton("Up") || Input.GetButton("Left") || Input.GetButton("Down") || Input.GetButton("Right"))
        {
            animator.SetTrigger("FemaleWalk");
            if (Input.GetButton("Up"))
                player.transform.Translate(0, speed * Time.deltaTime, 0);
            if (Input.GetButton("Down"))
                player.transform.Translate(0, -speed * Time.deltaTime, 0);
            if (Input.GetButton("Left"))
            {
                player.transform.Translate(-speed * Time.deltaTime, 0, 0);
                if (facingRight)
                    Flip();
            }
            if (Input.GetButton("Right"))
            {
                player.transform.Translate(speed * Time.deltaTime, 0, 0);
                if (facingRight == false)
                    Flip();
            }
        }
        else
            animator.SetTrigger("FemaleIdle");

        if (attacking)
        {
            if (attackTime > 0)
            {
                attackTime = attackTime - Time.deltaTime;
            }
            else
            {
                attacking = false;
                HitBox.enabled = false;
            }
        }

        //getting hit by enemy
        hit = false;
        if (invulCount >= 60 && invuln)
        {
            invuln = false;
            invulCount = 0;
        }
        if (invuln)
        {
            invulCount++;
        }
        if (currentHP <= 0 && !defeat && (HP_X <= 0 || HP_S <= 0 || HP_R <= 0))
        {
            currentHP = 0;
            defeat = true;
            animator.SetTrigger("FemaleDeath");
            deathTimer = deathDelay;
            dtime_start = true;
        }
        /*if (defeat)
        {
            //Destroy(gameObject);
            //gameObject.SetActive(false);
        }*/
        if (dtime_start)                         //Death animation
        {
            if (deathTimer > 0)
            {
                deathTimer = deathTimer - Time.deltaTime;
            }
            else
            {
                gameObject.SetActive(false);
                dtime_start = false;
                gameOverUI.SetActive(true);
                Time.timeScale = 0f;
            }
        }

        // ranged attack
        if (Input.GetButtonDown("Fire1") && characterno == 2 && !attacking)
        {
            attacking = true;
            attackTime = attackDelay;
            GameObject newArrow = Instantiate(arrow, transform.position, transform.rotation);
            if (facingRight)
            {
                newArrow.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(arrowSpeed, 0f));
            }
            else
            {
                Vector2 arrowScale = newArrow.transform.localScale;
                arrowScale.x *= -1;
                newArrow.transform.localScale = arrowScale;
                newArrow.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(-arrowSpeed, 0f));
            }
            Destroy(newArrow, 0.2f);
        }
        // status conditions
        /*if(Input.GetKeyDown("y"))
        {
            statusno = 0;
        }
        else if (Input.GetKeyDown("u"))
        {
            statusno = 1;
        }
        else if (Input.GetKeyDown("i"))
        {
            statusno = 2;
        }
        else if (Input.GetKeyDown("o"))
        {
            statusno = 3;
        }
        else if (Input.GetKeyDown("p"))
        {
            statusno = 4;
        }*/

        if (isABuffed)               //Buffs (Status Conditions for Player)
        {
            AtkBuff();
        }

        if (isDBuffed)
        {
            DefBuff();
        }

        if (isEnchantB)
        {
            EnchantBDuration();
        }
        if (isEnchantI)
        {
            EnchantIDuration();
        }
        /*count++;
     }
     else
     {
         count = 0;
         hit = false;
     }*/

        if (Input.GetKeyDown("1")) // Skills for 1 key
        {
            if (characterno == 1)        // Phase shift skill check
            {
                if ((SP_X - phaseShiftCost) >= 0 && phaseShiftCnt <= 0)
                {
                    SP_X -= phaseShiftCost;
                    if (Input.GetButton("Up"))
                        PhaseShift("Up");
                    else if (Input.GetButton("Down"))
                        PhaseShift("Down");
                    else if (Input.GetButton("Left"))
                        PhaseShift("Left");
                    else
                        PhaseShift("Right");
                }
                else if (phaseShiftCnt > 0)
                    Debug.Log("Skill on Cooldown");
                else
                    Debug.Log("Not enough SP");
            }
            else if (characterno == 2)
            {
                if ((SP_S - trapCost) >= 0 && trapCnt <= 0)
                {
                    SP_S -= trapCost;
                    GameObject newTrap = Instantiate(trap, transform.position, transform.rotation);
                    Destroy(newTrap, 5f);
                    isTrap = true;
                    trapCnt = trapCool;
                }
            }
            else if (characterno == 3)  // Fade skill check
            {
                Debug.Log(characterno);
                if ((SP_R - fadeCost) >= 0 && fadeCnt <= 0)
                {
                    SP_R -= fadeCost;
                    isInFade = true;
                    Debug.Log("Fade On");
                }
                else if (fadeCnt > 0)
                    Debug.Log("Skill on Cooldown");
                else if (SP_R < fadeCost)
                    Debug.Log("Not enough SP");
            }
        }
        if (phaseShiftCnt > 0) // Skills on cooldown
            phaseShiftCnt -= Time.deltaTime;
        else if (characterno == 1)
        {
            phaseShiftCnt = 0;
            Debug.Log("Phase shift ready");
        }
        if (fadeCnt > 0)
            fadeCnt -= Time.deltaTime;
        else if (characterno == 3 && isInFade == false)
        {
            fadeCnt = 0;
            Debug.Log("Fade ready");
        }
        if (trapCnt > 0)
        {
            trapCnt -= Time.deltaTime;
        }
        else if (characterno == 2)
        {
            trapCnt = 0;
        }
        if (characterno == 3)
        {
            // Controls Concealment
            if (concealTimeCnt > 1 && concealCoolCnt < 1)
            {
                concealTimeCnt -= Time.deltaTime;
                Debug.Log("Out of combat but visible");
            }
            if (concealCoolCnt > 1 && isConcealed == false)
            {
                concealCoolCnt -= Time.deltaTime;
                Debug.Log("Skill on Cooldown");
            }
            else if (concealCoolCnt < 1 && concealTimeCnt < 1)
            {
                concealTimeCnt = 0;
                concealCoolCnt = 0;
                isConcealed = true;
                Debug.Log("Currently concealed");
            }
            changeRocVisibility();
        }
        else
        {
            isConcealed = false;
            concealTimeCnt = timeOutOfCombat;
            mainCharacterColor = GetComponent<SpriteRenderer>().color;
            mainCharacterColor.a = a_regular;
            GetComponent<SpriteRenderer>().color = mainCharacterColor;
        }

        //else if (characterno == 3 && isConcealed == false)
        //    concealCoolCnt = 0;
        changeRocVisibility();
    }
    public void changeRocVisibility()
    {
        if (isConcealed == true)
        {
            mainCharacterColor = GetComponent<SpriteRenderer>().color;
            mainCharacterColor.a = a_concealed;
            GetComponent<SpriteRenderer>().color = mainCharacterColor;
        }
        else if (isConcealed == false)
        {
            mainCharacterColor = GetComponent<SpriteRenderer>().color;
            mainCharacterColor.a = a_regular;
            GetComponent<SpriteRenderer>().color = mainCharacterColor;
        }
    }
    //flipping directions
    void Flip()
    {
        facingRight = !facingRight;

        Vector2 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

    //taking arrow damage
    public void TakeArrowDamage(int arrowDamage)
    {
        if (characterno == 1)
        {
            if(arrowDamage < Def_X)
            {
                Debug.Log("No Damage");
                return;
            }
            else
            {
                HP_X -= arrowDamage - Def_X;
                currentHP = HP_X;
            }
        }
        else if (characterno == 2)
        {
            if (arrowDamage < Def_S)
            {
                Debug.Log("No Damage");
                return;
            }
            else
            {
                HP_S -= arrowDamage - Def_S;
                currentHP = HP_S;
            }
        }
        else if (characterno == 3 && isInFade == false)
        {
            concealTimeCnt = timeOutOfCombat;
            if (isConcealed == true)
            {
                isConcealed = false;
                changeRocVisibility();
                concealCoolCnt = concealCool;
            }
            if (isInFade == false && arrowDamage > Def_R)
            {
                HP_R -= arrowDamage - Def_R;
                currentHP = HP_R;
            }
        }
        if (isInFade == true) // reset fade trigger and activate cooldown
        {
            Debug.Log("No Damage");
            isInFade = false;
            fadeCnt = fadeCool;
        }
    }

    public void healthPot()                         //Health Potion implementation
    {
        if (hp_potion_cnt > 0)          //Checks to see if there are Health Potions in inventory
        {
            if (characterno == 1)           //Checks active character
            {
                if (HP_X == maxHP_X)        //Checks to see if active character is at full health
                {
                    return;
                }
                else
                {
                    HP_X += HPpot;              //Heals active character
                    if (HP_X > maxHP_X)         //Makes sure the current hp doesn't exceed the max hp
                    {
                        HP_X = maxHP_X;
                    }
                    hp_potion_cnt--;                                            //Subtracts from current inventory of Health Potions
                    PlayerPrefs.SetInt("CurrentHPPotion", hp_potion_cnt);
                }
            }
            else if (characterno == 2)          //Same procedure for other 2 characters
            {
                if (HP_S == maxHP_S)
                {
                    return;
                }
                else
                {
                    HP_S += HPpot;
                    if (HP_S > maxHP_S)
                    {
                        HP_S = maxHP_S;
                    }
                    hp_potion_cnt--;
                    PlayerPrefs.SetInt("CurrentHPPotion", hp_potion_cnt);
                }
            }
            else if (characterno == 3)
            {
                if (HP_R == maxHP_R)
                {
                    return;
                }
                else
                {
                    HP_R += HPpot;
                    if (HP_R > maxHP_R)
                    {
                        HP_R = maxHP_R;
                    }
                    hp_potion_cnt--;
                    PlayerPrefs.SetInt("CurrentHPPotion", hp_potion_cnt);
                }
            }
        }
    }

    public void SkillPot()                         //Skill Potion implementation
    {
        if (sp_potion_cnt > 0)          //Checks to see if there are Skill Potions in inventory
        {
            if (characterno == 1)           //Checks active character
            {
                if (SP_X == maxSP_X)        //Checks to see if active character is at full SP
                {
                    return;
                }
                else
                {
                    SP_X += SPpot;              //Heals active character
                    if (SP_X > maxSP_X)         //Makes sure the current sp doesn't exceed the max sp
                    {
                        SP_X = maxSP_X;
                    }
                    sp_potion_cnt--;                                            //Subtracts from current inventory of Skill Potions
                    PlayerPrefs.SetInt("CurrentSPPotion", sp_potion_cnt);
                }
            }
            else if (characterno == 2)          //Same procedure for other 2 characters
            {
                if (SP_S == maxSP_S)
                {
                    return;
                }
                else
                {
                    SP_S += SPpot;
                    if (SP_S > maxSP_S)
                    {
                        SP_S = maxSP_S;
                    }
                    sp_potion_cnt--;
                    PlayerPrefs.SetInt("CurrentSPPotion", sp_potion_cnt);
                }
            }
            else if (characterno == 3)
            {
                if (SP_R == maxSP_R)
                {
                    return;
                }
                else
                {
                    SP_R += SPpot;
                    if (SP_R > maxSP_R)
                    {
                        SP_R = maxSP_R;
                    }
                    sp_potion_cnt--;
                    PlayerPrefs.SetInt("CurrentSPPotion", sp_potion_cnt);
                }
            }
        }
    }

    public void setABuff()
    {
        if (atk_buff_cnt > 0)
        {
            if (isABuffed == false)
            {
                Atk_X += ATKbuff;
                Atk_S += ATKbuff;
                Atk_R += ATKbuff;
            }
            atk_buff_cnt--;
            PlayerPrefs.SetInt("CurrentAtkBuff", atk_buff_cnt);
            isABuffed = true;
            aBuff_start = aBuff_delay;
        }
    }

    public void AtkBuff()
    {
        if (aBuff_start > 0)
        {
            aBuff_start = aBuff_start - Time.deltaTime;
        }
        else
        {
            isABuffed = false;
            Atk_X -= ATKbuff;
            Atk_S -= ATKbuff;
            Atk_R -= ATKbuff;
        }
    }

    public void setDBuff()
    {
        if (def_buff_cnt > 0)
        {
            if (isDBuffed == false)
            {
                Def_X += DEFbuff;
                Def_S += DEFbuff;
                Def_R += DEFbuff;
            }
            def_buff_cnt--;
            PlayerPrefs.SetInt("CurrentDefBuff", def_buff_cnt);
            isDBuffed = true;
            dBuff_start = dBuff_delay;
        }
    }

    public void DefBuff()
    {
        if (dBuff_start > 0)
        {
            dBuff_start = dBuff_start - Time.deltaTime;
        }
        else
        {
            isDBuffed = false;
            Def_X -= DEFbuff;
            Def_S -= DEFbuff;
            Def_R -= DEFbuff;
        }
    }

    public void setEnchantB()
    {
        if (enchantB_cnt > 0)
        {
            if (isEnchantB == false)
            {
                statusno = 2;
            }
            enchantB_cnt--;
            PlayerPrefs.SetInt("CurrentEnchantB", enchantB_cnt);
            isEnchantB = true;
            enchantBurn_s = enchantBurn_d;
        }
    }

    public void EnchantBDuration()
    {
        if (enchantBurn_s > 0)
        {
            enchantBurn_s = enchantBurn_s - Time.deltaTime;
        }
        else
        {
            isEnchantB = false;
            statusno = 0;
        }
    }

    public void setEnchantI()
    {
        if (enchantI_cnt > 0)
        {
            if (isEnchantI == false)
            {
                statusno = 1;
            }
            enchantI_cnt--;
            PlayerPrefs.SetInt("CurrentEnchantI", enchantI_cnt);
            isEnchantI = true;
            enchantImmobile_s = enchantImmobile_d;
        }
    }

    public void EnchantIDuration()
    {
        if (enchantImmobile_s > 0)
        {
            enchantImmobile_s = enchantImmobile_s - Time.deltaTime;
        }
        else
        {
            isEnchantI = false;
            statusno = 0;
        }
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

    // Phase shift skill
    void PhaseShift(string direction)
    {
        GetComponent<SpriteRenderer>().enabled = false;
        //phaseShiftCnt = phaseShiftDelay;
        Vector2 pos = MainCharacters.transform.position;
        //else
        //{
        if (direction == "Up")
        {
            pos.y = pos.y + 2;
        }
        else if (direction == "Down")
        {
            pos.y = pos.y - 2;
        }
        else if (direction == "Left")
        {
            pos.x = pos.x - 2;
        }
        else
        {
            pos.x = pos.x + 2;
        }
        MainCharacters.transform.position = pos;
        phaseShiftCnt = phaseShiftDelay;
        //}
        GetComponent<SpriteRenderer>().enabled = true;
        phaseShiftCnt = phaseShiftCool;
    }
}