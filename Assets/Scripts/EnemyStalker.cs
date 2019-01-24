using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class EnemyStalker : MonoBehaviour
{
    //attributes
    public int Level;
    public int Exp;
    public int HP;
    public int SP;
    public int Atk;
    public int Def;
    public int Spd;

    //targeting the player
    public Collider2D player;
    public Transform target;
    
    //hitbox
    public Rigidbody2D enemy;
    public Collider2D e_HitBox;
    private Animator e_animator;

    //battle variables
    public bool defeat;
    public bool hit;
    public bool invuln;
    public int invulCount;
    public bool attacking;
    private float attackTime = 0;
    private float attackDelay = 1f;
    public bool dtime_start;
    public float deathTimer = 0;
    public float deathDelay = 1.5f;

    public float speed;
    public float buffedSpeed;
    private float saveSpeed;

    //AI variables
    public float range;
    public bool chase = false;
    private bool facingLeft = true;

    //status conditions
    public bool isImmobile = false;
    public float immobile_start = 0;
    public float immobile_delay = 5f;
    public bool isBurn = false;
    public float burn_start = 0;
    public float burn_delay = 5f;
    public int burn_cnt = 0;
    public bool isParalyze = false;
    public float para_start = 0;
    public float para_delay = 5f;
    public bool isSpeedUp = false;
    public float speed_start = 0;
    public float speed_delay = 5f;

    public GameObject enemyManager;

    //damage calculation
    public void gotHit(int attacker)
    {
        MainCharacter.concealTimeCnt = MainCharacter.timeOutOfCombat;
        if (MainCharacter.isConcealed == true)
        {
            MainCharacter.isConcealed = false;
            MainCharacter.concealCoolCnt = MainCharacter.concealCool;
        }
        if (!invuln)
        {
            if (attacker < Def)
            {
                Debug.Log("No Damage");
            }
            else
            {
                HP -= attacker - Def;
                invuln = true;
                Debug.Log("Damage Taken");
                EnemySoundManager.PlaySound("enemyArcherHit");
            }
        }
    }

    // Use this for initialization
    void Start()
    {
        //agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        Level = 1;
        Exp = 0;
        HP = 1000;
        SP = 50;
        Atk = 175;
        Def = 50;
        Spd = 20;

        e_HitBox.enabled = false;
        defeat = false;
        hit = false;
        invuln = false;
        attacking = false;
        invulCount = 0;
        range = 5;
        dtime_start = false;
        speed = Spd / 5;
        buffedSpeed = speed + 2f;

        e_animator = GetComponent<Animator>();

        saveSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        //calculate distance of enemy -> player
        float distance = Vector3.Distance(transform.position, target.position);
        if (distance < range && !MainCharacter.isConcealed)
        {
            chase = true;
        }
        else if (MainCharacter.isConcealed)
            chase = false;
        //attacking the player
        if (isBurn || isImmobile || isParalyze || isSpeedUp)
        {
            if (isBurn)
            {
                Burn();
            }
            else if (isImmobile)
            {
                Immobile();
            }
            else if (isParalyze)
            {
                Paralyze();
            }
            else
            {
                speedUp();
            }
        }
        if (distance <= 0.9f && !attacking && !isParalyze)
        {
            attacking = true;
            attackTime = attackDelay;
            e_HitBox.enabled = true;
            e_animator.SetTrigger("EnemyAttack");
            EnemySoundManager.PlaySound("enemySwordAttack1");
        }
        //chase function
        else if (chase && !defeat && !isImmobile)
        {
            /*transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            Vector3 targetDir = target.position - transform.position;
            float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 180);
            transform.Translate(Vector3.up * Time.deltaTime * speed);*/
            e_animator.SetTrigger("EnemyWalk");
            Vector3 targetDir = target.position - transform.position;
            if (targetDir.y > 0.01f && distance > 0.6f)
                enemy.transform.Translate(0, speed * Time.deltaTime, 0);
            else if (targetDir.y < -0.01f && distance > 0.6f)
                enemy.transform.Translate(0, -speed * Time.deltaTime, 0);
            if (targetDir.x < -0.01f && distance > 0.6f)
            {
                enemy.transform.Translate(-speed * Time.deltaTime, 0, 0);
                if (facingLeft == false)
                    Flip();
            }
            else if (targetDir.x > 0.01f && distance > 0.6f)
            {
                enemy.transform.Translate(speed * Time.deltaTime, 0, 0);
                if (facingLeft)
                    Flip();
            }
        }
        else
            e_animator.SetTrigger("EnemyIdle");

        if (attacking)
        {
            if (attackTime > 0)
            {
                attackTime = attackTime - Time.deltaTime;
            }
            else
            {
                attacking = false;
                e_HitBox.enabled = false;
            }
        }

        //behavior when taking damage
        hit = false;
        if (invulCount >= 60 && invuln)                     //Invulnerability
        {
            invuln = false;
            invulCount = 0;
        }
        if (invuln)
        {
            invulCount++;
        }
		if(HP <= 0 && !defeat)
		{
            HP = 0;
			defeat = true;
            e_animator.SetTrigger("EnemyDeath");
            EnemySoundManager.PlaySound("enemyDeathFemale");
            player.SendMessageUpwards("enemyDefeated", 500);            //Exp Given
            player.SendMessageUpwards("addGold", 2500);                 //Gold Given
            deathTimer = deathDelay;
            dtime_start = true;
            if (PlayerPrefs.GetInt("storyProgression") < 2)
            {
                PlayerPrefs.SetInt("storyProgression", 2);
            }
        }
        //what happens when enemy is defeated
		/*if(defeat)
        {
            //Destroy(gameObject);
            e_animator.SetTrigger("EnemyDeath");
            gameObject.SetActive(false);
        }*/
        if (dtime_start)
        {
            if (deathTimer > 0)
            {
                deathTimer = deathTimer - Time.deltaTime;
            }
            else
            {
                gameObject.SetActive(false);
                dtime_start = false;
                enemyManager.GetComponent<EnemyManager>().removeEnemy();
            }
        }
    }
    //taking arrow damage
    public void TakeArrowDamage(int arrowDamage)
    {
        if (arrowDamage < Def)
        {
            return;
        }
        HP -= arrowDamage - Def;
    }

    /*void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit");
        hit = true;
        if (!invuln)
        {
            gotHit(other.gameObject.GetComponent<MainCharacter>().Atk);
        }
    }*/
    //flip the character and hitbox function
    void Flip()
    {
        facingLeft = !facingLeft;

        Vector2 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
    void setDebuff(int statusno)
    {
        if (statusno == 1)
        {
            isImmobile = true;
            immobile_start = immobile_delay;
        }
        else if (statusno == 2)
        {
            isBurn = true;
            burn_start = burn_delay;
        }
        else if (statusno == 3)
        {
            isParalyze = true;
            para_start = para_delay;
        }
        else if (statusno == 4)
        {
            isSpeedUp = true;
            speed_start = speed_delay;
        }
    }
    void Immobile()
    {
        if(immobile_start > 0)
        {
            immobile_start = immobile_start - Time.deltaTime;
        }
        else
        {
            isImmobile = false;
        }
    }
    void Burn()
    {
        if (burn_start > 0)
        {
            burn_start = burn_start - Time.deltaTime;
            burn_cnt++;
            if(burn_cnt == 100)
            {
                HP = HP - 40;
                burn_cnt = 0;
            }
        }
        else
        {
            isBurn = false;
        }
    }
    void Paralyze()
    {
        if (para_start > 0)
        {
            para_start = para_start - Time.deltaTime;
        }
        else
        {
            isParalyze = false;
        }
    }
    void speedUp()
    {
        if (speed_start > 0)
        {
            if (speed_start == speed_delay)
            {
                speed = buffedSpeed;
            }
            speed_start = speed_start - Time.deltaTime;
        }
        else
        {
            isSpeedUp = false;
            speed = saveSpeed;
        }
    }
}