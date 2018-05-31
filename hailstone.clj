;; Define
(defn hailstone [n] 
  (cond (= n 1)         [1]
        (= (mod n 2) 0) (concat [n] (hailstone (/ n 2)))
        :else           (concat [n] (hailstone (inc (* n 3))))))


;; Test
(doall (map #(println % ": " (hailstone %)) (range 1 100)))

