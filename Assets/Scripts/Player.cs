using UnityEngine;

public class Player : MonoBehaviour, IPlayerMove {

    public Transform player;
    public Animator animator;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    public PlayerMove Forward { get; set; }
    public PlayerMove Left { get; set; }
    public PlayerMove Back { get; set; }
    public PlayerMove Right { get; set; }

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    private void Start(){

        Forward = new ForwardMove( player, animator, "F", KeyCode.W );
        Left = new LeftMove( player, animator, "L", KeyCode.A );
        Back = new BackMove( player, animator, "B", KeyCode.S );
        Right = new RightMove( player, animator, "R", KeyCode.D );

    }

    private void Update(){

        Forward.Move();
        Left.Move();
        Back.Move();
        Right.Move();

    }
    
}