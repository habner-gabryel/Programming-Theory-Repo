using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Skeleton : Enemy
{
    // INHERITANCE”
    public Skeleton(){
        this.characterName = "Skeleton";
        this.forceMovementSpeed = 1.2F;
        this.maxLife = 2;
        this.forceMultiplier = 0.7F;
        this.detectionRange = 60F;
    }
}
