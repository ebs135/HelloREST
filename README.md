# HelloREST
Simpe WCF Project for REST web service tutorial

Selamat datang di repositori HelloREST. Dalam repositori ini terdapat beberapa project, yaitu HelloREST.Server dan HelloREST.Client.

<**HelloREST.Server** merupakan project server web service dengan menggunakan template WCF pada Visual Studio 2015. Metode yang digunakan pada endpoint-nya adalah REST.
Sedangkan <**HelloREST.Client** merupakan sontoh project desktop windows form application untuk mengkonsumsi service dari HelloREST.Server.

<**Catatan:**
Kedua project tadi tergabung dalam satu solution <**HelloREST**. Untuk menjalankan project ini dengan baik Anda harus menjalankan Visual Studio dalam mode Administrator, dan fitur IIS pada komputer lokal juga harus sudah diaktifkan. Karena untuk debugging HelloREST.Server diperlukan IIS lokal dan application pool di mana virtual directory berada harus menggunakan identity local system.
