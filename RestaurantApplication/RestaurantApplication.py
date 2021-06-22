import os
masalar = dict()
for a in range(20):
    masalar[a] = 0

def ekle():
    masano=int(input("Masa No : "))
    gecerli= masalar[masano]
    eklenecek=float(input("Eklenecek ücret : "))
    toplam = gecerli + eklenecek
    masalar[masano]=toplam

def sil():
    masano=int(input("Masa No : "))
    gecerli=masalar[masano]
    eksilecek=float(input("Eksilecek Ücret : "))
    toplam = gecerli - eksilecek
    if toplam < 0 :
        print("İşlemde hata var!")
        print("Ana menüye dönmek için enter'e basınız!")
        input()
    else :
        masalar[masano]=toplam
        print("İşleminiz tamamlandı! Ana menüye dönmek için enter'e basınız!")

def kontrol(dosya_adi):
    try:
        dosya=open(dosya_adi)
        veriler=dosya.read()
        veriler=veriler.split("\n")
        veriler.pop()
        dosya.close()
        flag=True
    except FileNotFoundError:
        dosya=open(dosya_adi,"w")
        dosya.close()
        print("İlk kez çalıştırıldı! Kayıt dosyası oluşturuldu!")
        flag=False
    if flag:
        for a in enumerate(veriler):
            masalar[a[0]]=float(a[1])
    else:
        pass

def güncelle():
    dosya=open("defter.txt","w")
    for a in range(20):
        ücret=masalar[a]
        ücret=str(ücret)
        dosya.write(ücret+"\n")

def ana():
    kontrol("defter.txt")
    while True:
        os.system("cls")

        güncelle()

        print(""""
        
        
        
            Lokanta Hesap Uygulamasına Hoş Geldiniz :)
        
        1) Masaları Görüntüle
        2) Hesap Ekle
        3) Hesap Sil
        Q) Çıkış
        
        
        """)
        secim = input("İşlem Numarası Giriniz : ")

        if secim=="1":
            for a in range(20):
                print("Masa {} için hesap: {}".format(a,masalar[a]))
            print("İşleminiz tamamlandı! Ana menüye dönmek için enter'e basınız!")
            input()

        elif secim=="2":
            ekle()
            print("İşleminiz tamamlandı! Ana menüye dönmek için enter'e basınız!")
            input()

        elif secim=="3":
            sil()

        elif secim=="q" or secim=="Q":
            quit()

ana()