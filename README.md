HEPSİ BURADA CASE PROJECT

---Mars Rover ---

Bir grup robot araçları NASA tarafından marsta bir düzlüğe indiriliyor.Bu düzlük ilginç bir şekilde diktörgen şeklindedir.
Bu araçlar tarafından üzerlerinde bulunanan kameralarla burayı çevreleyen arazinin tüm manzarasının alınması gerekmektedir.
Böylece bunu dünyaya yollayabileceklerdir.

Aracın pozisyonun x-y koordinat düzlememinin kombinasyonları ve bir harfle ki bu harf bir pusulanın ana yönlerinin simgeler.
Arazi daha rahat navigasyon yapılması için grid haline bölünmüştür.Örnek pozisyon olarak 0,0,N aracın alt sol köşede kuzeye baktığını simgeler.

Aracı kontrol etmek için NASA string olarak bazı harfler göndermektedir.Olası  harfler L,R ve M'dir.L ve R harfi aracı sırasıyla 90 derece sağa ve sola döndürür,ama olduğu noktayı değiştirmez.M harfi ise grid sisteminde bir adım ileri götürür.

Şunu kabul edebilirsiniz ki x,y kuzeyde iken şimdi x,y+1'dedir.

--Giriş Değerleri--

İlk girilen satır üst sağ koordinatlar olacaktır,daha aşağıdaki koordinatların 0,0 olarak düşünebilirsiniz.
Geri kalan giriş bilgileri ise aracı istenen yere konuşlandırmak ile alakalı bilgiler olacaktır.Her aracın iki satır ver girişi olacaktır.
İlk girilen veri aracın pozisyonunu , ikinci girilen veri ise aracın araziyi nasıl keşfedeği ile alakalı veriler olacaktır.
Posizyon 2 sayı ve 1 harften oluşur aralarında boşluk vardır , x ve y koordinat düzlemine göre aracın konumunu temsil eder.
Her araç keşfi sıra sıra bitirecektir yani bir araç hareketi bitirmeden diğer araç harekete başlamayacaktır.

--Çıktı Değerleri--

Sonuç çıktısı x-y koordinat düzlemine göre bilgileri ve yön bilgisini içermeledir.

Örnek Giriş Değerleri 
5 5

1 2 N 
LMLMLMLMM 

3 3 E 
MMRMMRMRRM

Beklenen Çıktı Değerleri

1 3 N
5 1 E


