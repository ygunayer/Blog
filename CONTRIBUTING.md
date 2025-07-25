# Katkı Sağlama
Projeye katkı sağlamak için gerekli bilgiler ve katılım kuralları burada belirtilmiştir.

Bu bilgiler tüm katılımcılar tarafından dikkate alınmalı, kurallar hem kod eklemek isteyen katılımcılar, hem de eklenmek istenen kodları ineceleyip onaylayacak reviewer'lar tarafından uygulanmalıdır.

## Proje Yönetimi
Projenin yazılım geliştirme süreçleri, burada belirtilen GitHub Projects üzerinden takip edilmelidir: [@GamzeBuyuktorun - Blog](https://github.com/users/ygunayer/projects/5)

Yapılacak ya da yapılması gereken her iş bir GitHub Projects task'ıyla ilişkilendirilmelidir. Hali hazırda yapılacak işle ilgili bir task bulunmuyorsa, buna ilişkin yeni bir task oluşturulmalıdır.

Açılan her task'a yapılacak işi ve gereksinimleri listeleyen bir açıklama girilmeli; üzerinde çalışıldıkça bu task'ın anlık durumu (status), işin durumuna güncellenmelidir. Hangi iş aşamasının hangi task status'üne denk geldiği aşağıda belirtilmiştir:
- To-Do: Henüz başlanmamış, fakat yapılması kararlaştırılmış iş
- Blocked: Çeşitli sebeplerle henüz çalışılmaya başlanmayan iş. Neden üzerinde çalışılamadığı işin açıklamasında ya da yorumlarında belirtilmelidir
- In Progress: Üzerinde aktif olarak kod geliştirilen, yapımı devam eden iş. Bu aşamaya geçirilen iş'lar, ilgili geliştiriciye atanmalıdır
- Review: Aktif kod geliştirilmesi tamamlanıp, review edilmesi için Pull Request'i açılmış iş
- Test: Review edilip, ana branch'e merge edilmiş, geliştiricisi ya da başkaları tarafından test edilmekte olan iş
- Done: Tüm testlerden geçip, doğru çalıştığı teyit edilmiş iş

Testlerden geçtikten sonra Done'a çekilmiş, fakat sonrasında çalışmasıyla ilgili hataların/eksiklerin bulunduğu farkedilmiş task'lar Done'da bırakılmaya devam edilmeli; hata düzeltme ya da eksik gidermeye ilişkin yeni bir task açılmalıdır.

## Git'e Eklenecek/Eklenmeyecek Dosyalar
Yapılan her değişiklikte stage'deki dizin ve dosyalar gözden geçirilmeli, gerekli olmayanlar commit'lenmemelidir.

Diğer katılımcıların da bilgisayarlarında çalıştıkça karşılaşacağı fakat commit'lemek istemeyeceği dosya ya da dizinler, yazılım geliştirme yaşam döngüsünü kolaylaştırmak adına, doğru pattern'lar ile `.gitignore` dosyasına eklenmelidir.

Bir dosyanın Git'e eklenip eklenmeyeceği konusunda fikir yürütürken aşağıdaki örnekler incelenebilir:

Git'e **eklenmesi gereken** dosyalar:
- Kaynak kodları
- Görseller
- Veritabanı migration dosyaları
- Dokümantasyon dosyaları
- Paket yöneticisi lock dosyaları (örn. `package-lock.json`, `yarn.lock`)

Git'e **eklenmemesi gereken** dosyalar:
- Derleme çıktıları ve bunları içeren dizinler (örn. `*.exe`, `*.dll`, `Bin/Debug`, `*.zip`)
- Paket yöneticisi içerik dizinleri (örn. `node_modules`, Cargo projelerinde `target`)
- Compiler tarafından üretilen cache dosya ve dizinleri (örn. `__pycache__`, `*.__pyc`)
- Log dosyaları (`*.log`)

## Commit Mesajları
Git'e eklenecek her commit için bir mesaj girilmelidir. Girilen mesajlar, büyük harfle başlayıp, yapılmış olan işi kısaca anlatan ve emir kipi kullanan İngilizce cümleler olarak belirtilmelidir.

Hatalı commit mesajları:
- test
- sdf
- deneme
- değişiklikler yapıldı
- README.md güncellendi
- task yönetimi eklendi
- Added contribution guidelines

Doğru commit mesajları:
- Update README
- Add task management functionality
- Add contribution guidelines

## Branch Yönetimi
Projenin ana branch'i `main`'dir ve bu branch push koruması altındadır.

Projeye eklenmesi istenen değişiklikler için birer branch açılıp, bu branch'lerden `main` branch'ine Pull Request oluşturulmalıdır.

Branch kullanımı, Pull Request oluşturma, merge gibi işlemler ile ilgili bilgi almak için bu video'yu izleyebilirsiniz:
https://www.youtube.com/watch?v=DNsV8kz2fh4

## Katılımcılar
Projeye katkı sağlayan katılımcılar aşağıdaki listeye adlarını ve GitHub profil adreslerini eklemelidir:
- Yalın Günayer - [ygunayer](https://github.com/ygunayer)
- Gamze Büyüktorun - [GamzeBuyuktorun](https://github.com/GamzeBuyuktorun)

