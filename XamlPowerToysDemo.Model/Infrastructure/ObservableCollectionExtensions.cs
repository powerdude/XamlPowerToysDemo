namespace XamlPowerToysDemo.Model.Infrastructure {
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;

    public static class ObservableCollectionExtensions {

        public static void Sort<T>(this ObservableCollection<T> observable) where T : IComparable<T>, IEquatable<T> {
            var sorted = observable.OrderBy(x => x).ToList();

            var index = 0;
            while (index < sorted.Count) {
                if (!observable[index].Equals(sorted[index])) {
                    var t = observable[index];
                    observable.RemoveAt(index);
                    observable.Insert(sorted.IndexOf(t), t);
                } else {
                    index++;
                }
            }
        }

    }
}
