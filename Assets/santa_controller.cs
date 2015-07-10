using UnityEngine;
using System.Collections;

public class santa_controller : MonoBehaviour {

	// Use this for initialization
    private bool active=true;
    private int Dx;
    private int Dy;
    private Animator Santa_anim;
    private Rigidbody2D San_Speed;

    public float speed_santa = 1f;   

	void Start () {
        Santa_anim = GetComponent<Animator>();
        San_Speed = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (active)
        {
            Dx = (int)Input.GetAxisRaw("Horizontal");
            Dy = (int)Input.GetAxisRaw("Vertical");


            if (0 != Dx)  // чтобы не каталось по диагональке.
                Dy = 0;

            SetAnimation(Dx, Dy);
           MoveSanta (Dx, Dy);

            if (Input.GetButtonDown("Jump"))
            {
               // if (can_shoot == true)
                 //   StartCoroutine(ShootCoroutine()); ;
            }
        }



	}


    void SetAnimation(int x, int y)
    {
        Santa_anim.SetFloat("Diraction", (Mathf.Abs(x) - Mathf.Abs(y)));  //If >0  move_forward , if less? then  move  vert
    }

      void MoveSanta (int x,  int y )
    {
        San_Speed.velocity = new Vector2(speed_santa * x, speed_santa * y);
      }


  //  private IEnumerator ShootCoroutine()
   // {

      //  can_shoot = false;
     //   Bulet_start();
      //  yield return new WaitForSeconds(fire_beetween_time);

      //  can_shoot = true;
   // }


}
