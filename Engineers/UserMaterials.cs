using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engineers
{
    class UserMaterials
    {
        private List<Component> OwnedMaterials = new List<Component>();

        public UserMaterials()
        {
        }

        public List<Component> GetOwnedMaterials()
        { return OwnedMaterials; }

        public void AddOwnedMaterial(Component materialToAdd)
        { OwnedMaterials.Add(materialToAdd); }

        public bool RemoveOwnedMaterial(Component materialToRemove, int materialToRemoveCount)
        {
            if(GetMaterialOwnedCount(materialToRemove) < materialToRemoveCount)
            { return false; } //asking to remove more than the available mats.

            for(int x=0;x<=materialToRemoveCount;x++)
            {
                Component tmp = OwnedMaterials.Find(delegate (Component component) { return component.Name == materialToRemove.Name; });
                if (!OwnedMaterials.Remove(tmp))
                    return false; //something unexpected happened as we tried to remove something we thought we had but apparently didn't.
            }
            return true;
        }

        public int GetMaterialOwnedCount(Component materialToQuery)
        {
            List<Component> result = new List<Component>();
            result = OwnedMaterials.FindAll(delegate (Component component) { return component.Name == materialToQuery.Name; });
            return result.Count();
        }

    }

}
