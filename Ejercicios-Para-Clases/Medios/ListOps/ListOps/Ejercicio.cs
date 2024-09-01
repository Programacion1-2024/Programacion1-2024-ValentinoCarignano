﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOps
{
    /*
    Consigna:
        Implementar operaciones de lista básicas.

        En los lenguajes funcionales, las operaciones con listas como length, map y reduceson muy comunes. Implemente una serie de operaciones con listas básicas, sin utilizar funciones existentes.

        El número preciso y los nombres de las operaciones que se implementarán dependerán de la pista para evitar conflictos con los nombres existentes, pero las operaciones generales que implementará incluyen:

            append (dadas dos listas, agregue todos los elementos de la segunda lista al final de la primera lista);
            concatenate (dada una serie de listas, combine todos los elementos de todas las listas en una lista aplanada);
            filter (dado un predicado y una lista, devuelve la lista de todos los elementos para los que predicate(item)es Verdadero);
            length (dada una lista, devuelve el número total de elementos que contiene);
            map (dada una función y una lista, devuelve la lista de los resultados de la aplicación function(item)a todos los elementos);
            foldl (dada una función, una lista y un acumulador inicial, pliegue (reduzca) cada elemento en el acumulador desde la izquierda);
            foldr (dada una función, una lista y un acumulador inicial, pliegue (reduzca) cada elemento en el acumulador desde la derecha);
            reverse ( ada una lista, devuelve una lista con todos los elementos originales, pero en orden inverso).

        Tenga en cuenta que el orden en el que se pasan los argumentos a las funciones de pliegue (foldl, foldr) es significativo.

        Los métodos Foldly Foldr son funciones "fold", un concepto muy conocido en el mundo de la programación funcional, pero menos conocido en el mundo orientado a objetos. Si desea obtener más información, consulte esta página de fold: https://en.wikipedia.org/wiki/Fold_(higher-order_function).
    */

    public static class ListOps
    {
        public static int Length<T>(List<T> input)
        {
            throw new NotImplementedException("You need to implement this method.");
        }

        public static List<T> Reverse<T>(List<T> input)
        {
            throw new NotImplementedException("You need to implement this method.");
        }

        public static List<TOut> Map<TIn, TOut>(List<TIn> input, Func<TIn, TOut> map)
        {
            throw new NotImplementedException("You need to implement this method.");
        }

        public static List<T> Filter<T>(List<T> input, Func<T, bool> predicate)
        {
            throw new NotImplementedException("You need to implement this method.");
        }

        public static TOut Foldl<TIn, TOut>(List<TIn> input, TOut start, Func<TOut, TIn, TOut> func)
        {
            throw new NotImplementedException("You need to implement this method.");
        }

        public static TOut Foldr<TIn, TOut>(List<TIn> input, TOut start, Func<TIn, TOut, TOut> func)
        {
            throw new NotImplementedException("You need to implement this method.");
        }

        public static List<T> Concat<T>(List<List<T>> input)
        {
            throw new NotImplementedException("You need to implement this method.");
        }

        public static List<T> Append<T>(List<T> left, List<T> right)
        {
            throw new NotImplementedException("You need to implement this method.");
        }
    }
