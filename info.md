# Инструкция git

 Для создания репозитория вводим комманду 

 > git init
 
 Для проверки статуса папки и ее файлов ввводим команду

 > git status

  Для добавления файла/файлов к следующему коммиту вводим команду

  > git add "file name"

  Для создания коммита вводим команду

  > git commit

  Для вывода на экран истории всех коммитов с их хеш-кодами вводим комманду

  > git log

  Для перехода от одного коммита к другому вводим комманду

  > git checkout

  Для того, чтобы вернуться к актуальному состоянию и продолжить работу вводим программу

  > git checkout master

  Для того, чтобы увидеть разницу между текущим файлом и закоммиченным файлом вводим программу

  > git diff
## Ветвление и слияния

Для того, чтобы посмотреть список веток в репозитории вводим комманду

> git branch

Для того, чтобы создать новую ветку вводим комманду

> git branch "name branch"

Для того, чтобы, перейти из одной ветки в другую вводим комманду

> git checkout "name branch"

Для того, чтобы удалить ветку вводим комманду

> git branch -d "name branch"

## Удаленные репозитории

Для того, чтобы клонировать внешний репозиторий на локальный ПК вводим комманду

>git clone <url-адрес репозитория>

Для получения изменений и слияния с локальной версией используем комманду

> git pull 

Для того, чтобы отправить локальную версию репозитория на внешний репозиторий вводим комманду 

> git push

Для того, чтобы скопировать чужой репозиторий в свой аккаунт необходимо нажать: 

> Fork

Чтобы отправить запрос на рассмотрение репозитория необходимо нажать:

> Pull request 