# 🖥️ C# ile Temel Görüntü İşleme Algoritmaları (Görüntü İşleme Projesi)

Bu proje, dijital görüntü işlemenin temel yapı taşlarını oluşturan algoritmaların **C# programlama dili** kullanılarak, herhangi bir harici görüntü işleme kütüphanesine (örneğin OpenCV veya EmguCV) bağımlı kalınmadan *sıfırdan (from scratch)* geliştirilmesini amaçlamaktadır. 

Proje, matris manipülasyonları ve piksel tabanlı matematiksel operasyonların anlaşılmasına odaklanmakta olup, takım çalışması ve çevik (agile) proje yönetimi prensipleriyle GitHub üzerinden yürütülmektedir.

## 🚀 Proje Yönetimi ve İş Dağılımı

Bu proje 5 kişilik bir geliştirici takımı tarafından yürütülmektedir. Görev dağılımı, takım üyelerinin paralel çalışabilmesi ve GitHub üzerinde çakışmaların (merge conflicts) en aza indirilmesi amacıyla modüler olarak planlanmıştır.

| Geliştirici | Rol | Sorumlu Olduğu Algoritmalar / Modüller |
| :--- | :--- | :--- |
| **[Seyit]** | 👑 **Takım Lideri (Team Lead)** | 1. Görüntü Kırpma <br> 2. Görüntüye Filtre Uygulanması (Unsharp) <br> 3. Morfolojik İşlemler (Genişleme, Aşınma, Açma, Kapama) |
| **[Tesnim]** | 💻 Geliştirici | 1. Gri Dönüşüm <br> 2. Kontrast Artırma <br> 3. Kenar Bulma Algoritmalarının Kullanımı (Prewitt) |
| **[Aya]** | 💻 Geliştirici | 1. Görüntü Döndürme <br> 2. Görüntü Yaklaştırma/Uzaklaştırma (Zoom) <br> 3. Gürültü Ekleme (Salt&Pepper) ve Temizleme (Mean, Median) |
| **[Elmas]** | 💻 Geliştirici | 1. Renk Uzayı Dönüşümleri <br> 2. Histogram Germe/Genişletme <br> 3. Konvolüsyon İşlemi (Mean) |
| **[Hiba]** | 💻 Geliştirici | 1. Binary Dönüşüm <br> 2. Eşikleme İşlemleri (Tek Eşikleme) <br> 3. İki Resim Arasında Aritmetik İşlemler (Ekleme, Bölme) |

## 🛠️ Kullanılan Teknolojiler

* **Programlama Dili:** C# (.NET Framework / .NET Core)
* **Arayüz (GUI):** Windows Forms (WinForms) / WPF *(Projenizde hangisini kullanıyorsanız onu bırakın)*
* **Versiyon Kontrolü:** Git & GitHub
* **Temel Yaklaşım:** Harici kütüphane kullanmadan `Bitmap` sınıfı üzerinden `GetPixel` ve `SetPixel` (veya bellek optimizasyonu için `LockBits`) metodlarıyla doğrudan bellek erişimi.

## 🌿 GitHub İş Akışı (Workflow)

Takımımızın kod kalitesini korumak ve düzenli bir entegrasyon sağlamak için aşağıdaki Git iş akışı uygulanmaktadır:

1.  **Ana Dallar:** `main` (canlı/kararlı sürüm) ve `develop` (geliştirme sürümü).
2.  **Feature Branches:** Her geliştirici kendi algoritması için `develop` dalından yeni bir dal (branch) açar. *(Örn: `feature/gri-donusum`)*
3.  **Pull Request (PR):** Geliştirme tamamlandığında `develop` dalına bir PR açılır. Kodlar Takım Lideri tarafından gözden geçirilir (Code Review) ve onaylandıktan sonra birleştirilir.

## ⚙️ Kurulum ve Çalıştırma

1.  Projeyi yerel bilgisayarınıza klonlayın:
    ```bash
    git clone [https://github.com/](https://github.com/)[kullanici-adiniz]/[repo-adi].git
    ```
2.  Visual Studio'yu açın.
3.  `.sln` (Solution) dosyasını seçerek projeyi yükleyin.
4.  `F5` tuşuna basarak veya "Start" butonuna tıklayarak projeyi derleyip çalıştırın.

## 📋 Geliştirme Notları

* **Tip Dönüşümleri:** Piksel hesaplamalarında taşmaları (overflow) önlemek için ara değerler `double` veya `int` olarak tutulacak, atama yapılırken `byte` (0-255) aralığına kelepçelenecektir (clamping).
* **Performans:** İşlem sürelerini kısaltmak amacıyla, ilerleyen aşamalarda `LockBits` sınıfı ve `unsafe` kod blokları (pointer'lar) kullanılarak doğrudan bellek manipülasyonu hedeflenmektedir.

---
*Bu proje, üniversite Görüntü İşleme dersi kapsamında akademik kurallara uygun olarak geliştirilmiştir.*
