// поиск всех файлов в заданном каталоге, включая файлы, расположенные в подкаталогах произвольной вложенности.
// Для хождения по директориям используйте стандартную функцию. Результат выдавайте списком, List например.

// Для последних заданий подойдёт стандартный шаблон: делаете две функции, одна основная нерекурсивная, 
// которая получает исходные параметры, и вторая рекурсивная, которая вызывается из первой функции со своими начальными параметрами. 
// Это поможет вам избежать лишних параметров или глобальных переменных.

// Повышенная сложность (можете погуглить).
// Генерация всех корректных сбалансированных комбинаций круглых скобок (параметр -- количество открывающих скобок).
// Например,

// 1 = "()" 
// 2 = "(())" "()()"
// Внешне и внутренне несбалансированные комбинации считаются ошибочными:
// "()))" ")(()" "(()" -- неверно

using System;
using System.Collections.Generic;
using System.IO;

namespace Recursion
{
    public class Task8
    {
        static public List<string> GetAllFiles(string directory)
        {
            List<string> list = new List<string>();
            string[] folders = Directory.GetDirectories(directory);

            foreach (string folder in folders)
            {
                list.AddRange(GetAllFiles(folder));
            }

            string[] files = Directory.GetFiles(directory);

            foreach (string filePath in files)
            {
                string fileName = Path.GetFileName(filePath);
                list.Add(fileName);
            }

            return list;
        }

        static public List<string> getFilesNameByPath(string path)
        {
            return GetAllFiles(path);
        }
    }
}