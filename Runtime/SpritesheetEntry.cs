using System;
using UnityEngine;

namespace Audune.Spritesheet
{
  // Class that defines an entry in a spritesheet
  [Serializable]
  public class SpritesheetEntry
  {
    // Sprite settings
    [Tooltip("The name of the sprite")]
    public string name;
    [Tooltip("The position of the sprite")]
    public Rect rect;
    [Tooltip("The pivot of the sprite")]
    public Vector2 pivot;
    [Tooltip("The border of the sprite (w = top, x = left, y = bottom, z = right)")]
    public Vector4 border;


    // Constructor
    public SpritesheetEntry(string name, Rect rect, Vector2? pivot = null, Vector4 ? border = null)
    {
      this.name = name;
      this.rect = rect;
      this.pivot = pivot ?? Vector2.zero;
      this.border = border ?? Vector4.zero;
    }
  }
}
