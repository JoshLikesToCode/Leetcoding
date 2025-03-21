public class Solution {
    public IList<string> FindAllRecipes(string[] recipes, IList<IList<string>> ingredients, string[] supplies) {
        var hs = supplies.ToHashSet();
        var linkedList = new LinkedList<int>();
        for(var idx = 0; idx < recipes.Length; idx++)
            linkedList.AddFirst(idx);
        var createdRecipes = new List<string>();
        int lastSize = -1;
        while(hs.Count != lastSize)
        {
            lastSize = hs.Count;
            var qSize = linkedList.Count;
            while(qSize-- > 0)
            {
                var recipeIdx = linkedList.Last.Value;
                linkedList.RemoveLast();
                var canCreate = true;
                foreach(var ingredient in ingredients[recipeIdx]) 
                {
                    if (!hs.Contains(ingredient)) 
                    {
                        canCreate = false;
                        break;
                    }
                }

                if (!canCreate) 
                    linkedList.AddFirst(recipeIdx);
                else 
                {
                    // Recipe can be created - add to available items
                    hs.Add(recipes[recipeIdx]);
                    createdRecipes.Add(recipes[recipeIdx]);
                }
            }
        }
        return createdRecipes;
    }
}