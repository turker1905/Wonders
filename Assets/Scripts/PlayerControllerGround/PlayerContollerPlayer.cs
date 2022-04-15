
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContollerPlayer : MonoBehaviour
{
    [SerializeField] Animator _animation;
    [SerializeField] Transform _playerTransformX, _playerTransformY;
    [SerializeField] Rigidbody2D _playerRigitJump;
    [Range(5, 10)] [SerializeField] float _playerSpeedX, _playerSpeedY;
    [Range(250, 350)] [SerializeField] float _playerJumpSpeed;
    [SerializeField] bool _horizontalActive, _verticalActive, _jumpActive;
    bool _jumpActiveif;
    PlayerMoveCompanent _playerMoveCompanent;
    [SerializeField] SpriteRenderer _spriteRenderer;

    [Range(10,25)][SerializeField] int attackDamage;

    public bool IsJumpAction => _playerRigitJump.velocity != Vector2.zero;
    
    private void Awake()
    {
        _playerMoveCompanent = new PlayerMoveCompanent();
    }
    void Start()
    {

    }
    void Update()
    {
        JActive();
    }
    private void FixedUpdate()
    {
        HorzintalMove();
        VerticalMove();
        JumpMove();
        PlayerAnimation();
     
    }

    public void HorzintalMove() // X ekseni hareket metodu
    {
        _playerMoveCompanent.PlayerXAxis(_playerTransformX, _playerSpeedX, _horizontalActive);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            _spriteRenderer.flipX = true;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _spriteRenderer.flipX = false;
        }
    }
    public void VerticalMove() // Y ekseni hareket metodu
    {
        _playerMoveCompanent.PlayerYAxis(_playerTransformY, _playerSpeedY, _verticalActive);
    }
    public void JActive() // Space tusuna basilinca aktif etmeyi saglayan metot
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _jumpActiveif = true;
        }
    }
    public void JumpMove() // Ziplama Script Metodu
    {
        if (_jumpActiveif && !IsJumpAction)
        {
            _playerMoveCompanent.PlayerJumpAxis(_playerRigitJump, _playerJumpSpeed, _jumpActive);
        }
        else
        {
            _jumpActiveif = false;
        }

        
    }
    public void PlayerAnimation() //Hareket Animasyon kodlari
    {

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            _animation.Play("PlayerRun");
        }
        else
        {
            _animation.Play("PlayerIdle");
            
        }
    }






}
