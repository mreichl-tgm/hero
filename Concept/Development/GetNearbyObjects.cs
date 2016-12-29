 function Update()
 {
     print("Closest Object is " + GetClosestObject("tagName").name);
 }
 
 function GetClosestObject(tag:String) : GameObject
 {
     var objectsWithTag = GameObject.FindGameObjectsWithTag(tag);
     var closestObject : GameObject;
     for (var obj : GameObject in objectsWithTag)
     {
         if(!closestObject)
         {
            closestObject = obj;
         }
         //compares distances
         if(Vector3.Distance(transform.position, obj.transform.position) <= Vector3.Distance(transform.position, closestObject.transform.position))
         {
            closestObject = obj;
         }
     }
     return closestObject;
 }