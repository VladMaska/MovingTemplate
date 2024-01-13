using UnityEngine;

/*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

public abstract class PlayerMove {
    
    protected const float MoveSpeed = 1f;

    protected abstract void Execute( bool b = true );

    public abstract void Move();

}

/*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

public class ForwardMove : PlayerMove {
    
    private Transform _player;
    private Animator _anim;
    private string _parameter;
    private KeyCode _key;

    public ForwardMove( Transform player, Animator anim, string parameter, KeyCode key ){

        _player = player;
        _anim = anim;
        _parameter = parameter;
        _key = key;

    }

    protected override void Execute( bool b = true ) => _anim.SetBool( _parameter, b );
    
    public override void Move(){
        
        if ( Input.GetKeyDown( _key ) )
            Execute();
        
        if ( Input.GetKey( _key ) ){
            
            var movement = new Vector3( 0f, 0f, 1f );
            _player.Translate( movement * MoveSpeed * Time.deltaTime );
            
        }
        
        if ( Input.GetKeyUp( _key ) )
            Execute( false );

    }
    
}

public class LeftMove : PlayerMove {
    
    private Transform _player;
    private Animator _anim;
    private string _parameter;
    private KeyCode _key;

    public LeftMove( Transform player, Animator anim, string parameter, KeyCode key ){

        _player = player;
        _anim = anim;
        _parameter = parameter;
        _key = key;

    }

    protected override void Execute( bool b = true ) => _anim.SetBool( _parameter, b );
    
    public override void Move(){
        
        if ( Input.GetKeyDown( _key ) )
            Execute();
        
        if ( Input.GetKey( _key ) ){
            
            var movement = new Vector3( -1f, 0f, 0f );
            _player.Translate( movement * MoveSpeed * Time.deltaTime );
            
        }
        
        if ( Input.GetKeyUp( _key ) )
            Execute( false );

    }
    
}

public class BackMove : PlayerMove {
    
    private Transform _player;
    private Animator _anim;
    private string _parameter;
    private KeyCode _key;

    public BackMove( Transform player, Animator anim, string parameter, KeyCode key ){

        _player = player;
        _anim = anim;
        _parameter = parameter;
        _key = key;

    }

    protected override void Execute( bool b = true ) => _anim.SetBool( _parameter, b );
    
    public override void Move(){
        
        if ( Input.GetKeyDown( _key ) )
            Execute();
        
        if ( Input.GetKey( _key ) ){
            
            var movement = new Vector3( 0f, 0f, -1f );
            _player.Translate( movement * MoveSpeed * Time.deltaTime );
            
        }
        
        if ( Input.GetKeyUp( _key ) )
            Execute( false );

    }
    
}

public class RightMove : PlayerMove {
    
    private Transform _player;
    private Animator _anim;
    private string _parameter;
    private KeyCode _key;

    public RightMove( Transform player, Animator anim, string parameter, KeyCode key ){

        _player = player;
        _anim = anim;
        _parameter = parameter;
        _key = key;

    }

    protected override void Execute( bool b = true ) => _anim.SetBool( _parameter, b );
    
    public override void Move(){
        
        if ( Input.GetKeyDown( _key ) )
            Execute();
        
        if ( Input.GetKey( _key ) ){
            
            var movement = new Vector3( 1f, 0f, 0f );
            _player.Translate( movement * MoveSpeed * Time.deltaTime );
            
        }
        
        if ( Input.GetKeyUp( _key ) )
            Execute( false );

    }
    
}

/*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

public interface IPlayerMove {
    
    public PlayerMove Forward { get; set; }
    public PlayerMove Left { get; set; }
    public PlayerMove Back { get; set; }
    public PlayerMove Right { get; set; }

}