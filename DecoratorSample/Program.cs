using DecoratorSample;

INotifier notifier = new Notifier("The system is currently down!");

notifier = new FacebookDecorator(notifier);

notifier.SendMessage();