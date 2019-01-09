// Decompiled with JetBrains decompiler
// Type: TopDownShooter155.EnemyShoot
// Assembly: TopDownShooter155, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F68E7312-5151-40B4-BDF6-319A399A5F53
// Assembly location: C:\Users\Vespies\Desktop\Shooty\Assets\DontTouch\Plugins\TopDownShooter155.dll

using UnityEngine;

namespace TopDownShooter155
{
  public class EnemyShoot : MonoBehaviour
  {
    public Transform shootPoint;
    public GameObject bulletPrefab;
    public float firetime = 0.5f;

    private void Start()
    {
      Invoke("Shoot", firetime);
    }

    private void Shoot()
    {
     Vector3 bulletPosition = shootPoint.position;
     Quaternion bulletRotation = shootPoint.rotation;
     Instantiate(bulletPrefab, bulletPosition, bulletRotation);
    }
  }
}
