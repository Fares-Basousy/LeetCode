// Last updated: 7/30/2025, 3:13:55 PM
public class LRUCache {
    private int DicCapacity ;
    private List<int> UsedKeys  ;
    private Dictionary <int,int> cache ;
    public LRUCache(int capacity) {
        DicCapacity = capacity;
        cache = new Dictionary<int, int>();
        UsedKeys = new List<int>(); 
    }
    
    public int Get(int key) {
        if( cache.ContainsKey(key) ){
            UsedKeys.Remove(key);
            UsedKeys.Insert(0,key);
            if (UsedKeys.Count > DicCapacity){
                int LRU = UsedKeys[DicCapacity];
                UsedKeys.Remove(LRU);
                cache.Remove(LRU);
               }
               
            return cache[key];
            }
        else
            return -1;
    }
    
    public void Put(int key, int value) {
        if(cache.ContainsKey(key)){
            cache[key] = value;
            UsedKeys.Remove(key);     
            UsedKeys.Insert(0,key);
            return  ;
        }
        else if(cache.Count == DicCapacity){
            int OldestKey = UsedKeys.Last() ;
            UsedKeys.Remove(OldestKey);                
            cache.Remove(OldestKey);
        }
        cache.Add(key,value);
        UsedKeys.Insert(0,key);
                        
        
        
    }

}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */