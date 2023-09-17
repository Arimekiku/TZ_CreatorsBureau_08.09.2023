﻿using UnityEngine;

public class PlayerBulletFactory : GameFactory
{
    private const string BulletPrefabPath = "Prefabs/Player/PlayerBullet";
    
    public PlayerBulletFactory(Transform newParent) : base(newParent)
    {
        PlayerBullet bulletPrefab = Resources.Load<PlayerBullet>(BulletPrefabPath);
        
        DefaultInstancesPrefabs.Add(bulletPrefab);
    }
    
    public PlayerBullet CreateInstance()
    {
        PlayerBullet newBullet = CreateInstance<PlayerBullet>();
        newBullet.Init();
        
        return CreateInstance<PlayerBullet>();
    }
}