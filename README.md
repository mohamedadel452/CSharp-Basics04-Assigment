<div dir="rtl">

# 💻 أساسيات C# — المحاضرة 04: المصفوفات (1D & 2D Arrays) وتمرير المعاملات للدوال (Value / ref / out / params)
### C# Basics 04: Arrays Memory Layout & Method Parameter Semantics (ref, out, params)

[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-14.0-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![Module](https://img.shields.io/badge/Module-01_CSharp_Basics-0284c7?style=for-the-badge)](#)
[![Interactive Guide](https://img.shields.io/badge/%F0%9F%8C%90_Live_Study_Guide-HTML_Interactive-8b5cf6?style=for-the-badge)](https://htmlpreview.github.io/?https://github.com/mohamedadel452/CSharp-Basics04-Assigment/blob/master/Study_Guide/CSharp_Basics_Session04_Guide.html)

> **نبذة عن المشروع:** 📘 [01 C# Basics - Session 04] 1D & 2D Rectangular Arrays, Pass by Value vs Pass by Reference (ref, out), Optional/Named Arguments & params Keyword with Interactive HTML Guide.

---

## 🌐 الدليل التفاعلي المشروح بالـ HTML (Interactive Study Guide)

تم تضمين الدليل التفاعلي المشروح بالكامل داخل مجلد [`Study_Guide/`](./Study_Guide) في هذا المستودع، ويمكنك قراءته مباشرة في المتصفح عبر الروابط التالية:

- 🌐 الدليل التفاعلي الشامل لـ Session 04 (HTML): **[🌐 معاينة حية في المتصفح (Live Preview)](https://htmlpreview.github.io/?https://github.com/mohamedadel452/CSharp-Basics04-Assigment/blob/master/Study_Guide/CSharp_Basics_Session04_Guide.html)** | **[📄 فتح ملف الـ HTML في المستودع](./Study_Guide/CSharp_Basics_Session04_Guide.html)**
- 📂 **[فتح مجلد المحاضرة المحلي الكامل في `nots` (للتصفح المحلي على الجهاز)](../../../../nots/01_CSharp-Basics/Session_04_Nullability_Arrays_&_Methods)**

---

### 🧠 الملاحظات الهندسية والمفاهيم المعمارية (Engineering Notes)
1. **معمارية المصفوفات في الذاكرة (`1D` و `2D Rectangular Arrays`):**
   - المصفوفات في C# هي أنواع مرجعية (`Reference Types`) ترث من `System.Array` وتُخزن بشكل متصل في الـ `Heap`. المصفوفة ثنائية الأبعاد `int[,] shelfCopies = new int[2, 2]` تُحجز ككتلة واحدة متصلة في الذاكرة (Row-Major Layout).
2. **التحليل الدقيق لتمرير المعاملات في الـ Stack Frame:**
   - **تمرير `Value Type` بالقيمة (`AddBonusPages(int pages)`):** ينسخ القيمة؛ المتغير الأصلي لا يتغير (`400`).
   - **تمرير `Reference Type` بالقيمة (`ApplyDiscount(double[] prices)`):** ينسخ المؤشر فقط؛ تعديل عناصر المصفوفة `prices[0] -= 5` ينعكس على المصفوفة الأصلية في الـ `Heap`، لكن إعادة توجيه المؤشر نفسه بدون `ref` لا يغير مؤشر المستدعي.
   - **التمرير بالمرجع (`ref int` و `ref double[]`):** يمرر عنوان المتغير نفسه في الـ `Stack` (`Managed Pointer`)، مما يسمح بتعديل قيمة المتغير الأصلي (`450`) أو استبدال المصفوفة بالكامل بمصفوفة جديدة في `ReplaceArray(ref myPrices)`!
   - **معامل الخرج (`out double price`):** يلزم الدالة بتعيين قيمة للمتغير قبل إرجاع النتيجة، وهو الأساس في بناء دوال `TryGetPrice`.
   - **المعاملات الاختيارية، المسماة، و `params`:** تمنح مرونة عالية في استدعاء الدوال بعدد متغير من القيم.

---

## 🗂️ هيكلة الكود والتمارين التطبيقية المحلولة

| السؤال | المفهوم الهندسي | التطبيق في الكود |
| :--- | :--- | :--- |
| **Q1 & Q2** | 1D & 2D Multidimensional Arrays | إنشاء مصفوفة أسعار `double[]` ومصفوفة أرفف ثنائية الأبعاد `int[2,2]`. |
| **Q3 & Q4** | Static Void Methods & Parameters | بناء دوال `PrintWelcomeMessage()` و `PrintBookTitle(string)`. |
| **Q5 & Q6** | Pass by Value (Value Type vs Reference Type) | إثبات بقاء `int` كما هو (`400`) مقابل تأثر عناصر `double[]` (`20.5`). |
| **Q7 & Q8** | Pass by Reference (`ref int` & `ref double[]`) | تعديل المتغير الأصلي بـ `ref` واستبدال مرجع المصفوفة بالكامل في `ReplaceArray`. |
| **Q9** | `out` Parameter (`TryGetPrice`) | إرجاع حالة البحث `bool` مع السعر المستخرج عبر `out double price`. |
| **Q10 – Q12** | Optional, Named & `params` Arguments | استدعاء `PrintBookInfo` بمعاملات افتراضية ومسماة، و `PrintAllTitles(params string[])`. |

---

## 🧭 خريطة مسار هندسة `.NET` الكامل على GitHub

| # | المرحلة (Module) | المستودع (Repository) | الموضوع الرئيسي | الدليل التفاعلي (Live HTML) |
| :---: | :--- | :--- | :--- | :---: |
| **01** | `01_CSharp_Basics` | **[`CSharp-Basics02-Assigment`](https://github.com/mohamedadel452/CSharp-Basics02-Assigment)** | أنواع البيانات، نموذج الكائنات (System.Object)، والتحويلات | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/CSharp-Basics02-Assigment/blob/master/Study_Guide/CSharp_Basics_Session02_Guide.html) |
| **02** | `01_CSharp_Basics` | **[`CSharp-Basics03-Assigment`](https://github.com/mohamedadel452/CSharp-Basics03-Assigment)** | معمارية النصوص (Strings & StringBuilder)، جمل التحكم، والحلقات | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/CSharp-Basics03-Assigment/blob/master/Study_Guide/CSharp_Basics_Session03_Guide.html) |
| **03** | `01_CSharp_Basics` | **[`CSharp-Basics04-Assigment`](https://github.com/mohamedadel452/CSharp-Basics04-Assigment)** | المصفوفات (1D & 2D Arrays) وتمرير المعاملات للدوال (Value / ref / out / params) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/CSharp-Basics04-Assigment/blob/master/Study_Guide/CSharp_Basics_Session04_Guide.html) |
| **04** | `01_CSharp_Basics` | **[`CSharp-Basics05-Assigment`](https://github.com/mohamedadel452/CSharp-Basics05-Assigment)** | محددات الوصول (Access Modifiers)، التغليف، والـ Enums | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/CSharp-Basics05-Assigment/blob/master/Study_Guide/CSharp_Basics_Session05_Guide.html) |
| **05** | `02_OOP` | **[`OOP-Session-01-Assigment`](https://github.com/mohamedadel452/OOP-Session-01-Assigment)** | الـ Struct، التغليف، الخصائص، والـ Indexers (نظام Smart Delivery) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-01-Assigment/blob/master/Study_Guide/OOP_Session01_Deep_Dive.html) |
| **06** | `02_OOP` | **[`OOP-Session-02-Assigment`](https://github.com/mohamedadel452/OOP-Session-02-Assigment)** | الفئات (Classes)، الوراثة، وتسلسل الـ Constructors (Smart Delivery Part 1) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-02-Assigment/blob/master/Study_Guide/OOP_Session02_Deep_Dive.html) |
| **07** | `02_OOP` | **[`OOP-Session-03-Assigment`](https://github.com/mohamedadel452/OOP-Session-03-Assigment)** | تعدد الأشكال (Polymorphism)، الربط الديناميكي، والكلاسات المختومة (Sealed) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-03-Assigment/blob/master/Study_Guide/OOP_Session03_04_Dispatch_&_SOLID_Deep_Dive.html) |
| **08** | `02_OOP` | **[`OOP-Session-04-Assigment`](https://github.com/mohamedadel452/OOP-Session-04-Assigment)** | التجريد (Abstraction)، الفئات المجردة، والواجهات (Smart Delivery Part 3) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-04-Assigment/blob/master/Study_Guide/OOP_Session04_Deep_Dive.html) |
| **09** | `02_OOP` | **[`OOP-Session-05-Assigment`](https://github.com/mohamedadel452/OOP-Session-05-Assigment)** | نسخ الكائنات، Static، دوال التوسيع، والـ Partial Classes (Smart Delivery Final) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/OOP-Session-05-Assigment/blob/master/Study_Guide/OOP_Session05_Deep_Dive.html) |
| **10** | `03_Advanced_CSharp` | **[`Advanced-CSharp-01`](https://github.com/mohamedadel452/Advanced-CSharp-01)** | الأنواع المعممة (Generics)، القيود (Constraints)، والـ Variance | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/Advanced-CSharp-01/blob/master/Study_Guide/Generics_Deep_Part1_Core.html) |
| **11** | `03_Advanced_CSharp` | **[`Advanced-CSharp-02`](https://github.com/mohamedadel452/Advanced-CSharp-02)** | المفوضات (Delegates)، تعبيرات Lambda، ونظام ShopMaster | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/Advanced-CSharp-02/blob/master/Study_Guide/Delegates_Part1_Core.html) |
| **12** | `03_Advanced_CSharp` | **[`Advanced-CSharp-03`](https://github.com/mohamedadel452/Advanced-CSharp-03)** | معمارية هياكل البيانات والـ Collections (6 أنظمة تطبيقية) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/Advanced-CSharp-03/blob/master/Study_Guide/session03-part1-collections-list.html) |
| **13** | `04_Database` | **[`Database-Session-01-Assigment`](https://github.com/mohamedadel452/Database-Session-01-Assigment)** | تصميم قواعد البيانات، مخططات الـ ERD، والتحويل العلائقي (Relational Mapping) | [🌐 فتح الشرح التفاعلي](https://htmlpreview.github.io/?https://github.com/mohamedadel452/Database-Session-01-Assigment/blob/master/Study_Guide/ERD_Part1_Design_Intro.html) |

---

## 🚀 طريقة التشغيل المحلي (How to Run)

```bash
git clone https://github.com/mohamedadel452/CSharp-Basics04-Assigment.git
cd CSharp-Basics04-Assigment
dotnet run --project "C#-Basics04-Assigment/C#-Basics04-Assigment.csproj"
```

**إعداد وتطوير:** [محمد عادل محمد بيومي (mohamedadel452)](https://github.com/mohamedadel452) — كلية الحاسبات والمعلومات، جامعة عين شمس.

</div>
