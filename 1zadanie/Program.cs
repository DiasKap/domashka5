int[] Size_array(int size, int minv, int maxv){
    int[] array= new int[size];
    for (int i=0; i<size;i++){
        array[i]=new Random().Next(minv,maxv);
    }
    return array;
}
int count(int[] array){
    int count=0;
    foreach(int el in array){
        if (el%2==0){
            count+=1;
    }}
    return count;}
int[] array=Size_array(5,100,1000);  
Console.WriteLine(count(array));
Console.Write(String.Join(", ", array));  