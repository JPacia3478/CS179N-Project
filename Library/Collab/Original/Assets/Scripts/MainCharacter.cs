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
    public int HP;
    public Text HPText;
    public int SP;
    public Text SPText;
    public int Atk;
    public Text AtkText;
    public int Def;
    public Text DefText;
    public int Spd;
    public Text SpdText;

    //battle variables
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

    //movement variables
    private bool facingRight = true;
    public float speed;

    //colliders and animation
    private Rigidbody2D player;
    public Collider2D HitBox;
    private Animator animator;

    //ranged variables
    public GameObject arrow;
    public float arrowSpeed;

    public void levelUp()
    {
        Level++;
        lvlText.text = "Level " + Level;
        HP += 50;
        SP += 25;
        Atk += 7;
        Def += 3;
        Spd += 5;
    }
    public void updateHP()
    {
        HPText.text = "HP     " + HP;
    }
    public void updateSP()
    {
        SPText.text = "SP     " + SP;
    }
    public void updateNextLevel()
    {
        nxtLvl.text = "Next Level     " + (ExpCap - Exp);
    }
    public void enemyDefeated(int attackerExp)
    {
        Exp += attackerExp;
        if(Exp >= ExpCap)
        {
            Exp -= ExpCap;
            if(Exp < 0)
            {
                Exp = 0;
            }
            ExpCap += 50;
            levelUp();
        }
    }

    public void addGold(int g)
    {
        Gold += g;
    }

    public void gotHit(int attacker)
    {
        if (!invuln)
        {
            HP -= attacker - Def;
            invuln = true;
            Debug.Log("Player Damage Taken");
        }
    }

    // Use this for initialization
    void Start()
    {
        Level = 1;
        Exp = 0;
        ExpCap = 50;
        HP = 450;
        SP = 150;
        Atk = 100;
        Def = 40;
        Spd = 25;
        speed = Spd / 5;

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

        player = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //UI updates
        speed = Spd / 5;
        updateHP();
        updateSP();
        goldText.text = "Gold     " + Gold;
        currExp.text = "Experience     " + Exp;
        updateNextLevel();
        AtkText.text = "Attack    " + Atk;
        DefText.text = "Defense   " + Def;
        SpdText.text = "Speed     " + Spd;
        //movement and attacking
        if (Input.GetKeyDown("l") && !attacking)
        {
            attacking = true;
            attackTime = attackDelay;
            HitBox.enabled = true;

            animator.SetTrigger("FemaleAttack");
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
        if (HP <= 0 && !defeat)
        {
            HP = 0;
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
        if(dtime_start)
        {
            if (deathTimer > 0)
            {
                deathTimer = deathTimer - Time.deltaTime;
            }
            else
            {
                gameObject.SetActive(false);
                dtime_start = false;
            }
        }

        // ranged attack
        if (Input.GetButtonDown("Fire1"))
        {
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
            Destroy(newArrow, 1f);
        }
        /*count++;
     }
     else
     {
         count = 0;
         hit = false;
     }*/
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
        HP -= arrowDamage - Def;
    }
}