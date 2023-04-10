int[] Size_array(int size, int minv, int maxv){
    int[] array= new int[size];
    for (int i=0; i<size;i++){
        array[i]=new Random().Next(minv,maxv);
    }
    return array;
}
int count(int[] array){
    int count=0;
    for(int i=0; i<array.Length; i++){
        if (i%2!=0){
            count+=array[i];
    }}
    return count;}
int[] array=Size_array(5,10,100);  
Console.WriteLine(count(array));
Console.Write(String.Join(", ", array));  