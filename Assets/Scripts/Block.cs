using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {
    [SerializeField] AudioClip breakSound;

    //cached reference
    LevelManager levelManager;

    private void Start()
    {
        levelManager = FindObjectOfType<LevelManager>(); 
        levelManager.CountBreakableBlocks();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBlock();
    }

    private void DestroyBlock()
    {
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        FindObjectOfType<GameStatus>().AddToScore();
        Destroy(gameObject);
        levelManager.BlockDestroyed();
    }
}
